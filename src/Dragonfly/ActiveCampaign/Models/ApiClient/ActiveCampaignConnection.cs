namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Text;
    using Dragonfly.ActiveCampaign.Extensions;
    using Dragonfly.ActiveCampaign.Helpers;
    using Newtonsoft.Json;

    /*
	 * Version 3 of the ActiveCampaign API
	 * see: https://developers.activecampaign.com/reference?_ga=2.79471828.1564152.1611946105-1183065105.1584984488#overview
	 */
    public class ActiveCampaignConnection : IDisposable
    {
        public string AccountApiUrl { get; }

        public string ApiKey { get; }

        internal WebClient WebClient => _lazyWebClient.Value;

        private readonly Lazy<WebClient> _lazyWebClient;

        private readonly string _baseAddress;

        public ActiveCampaignConnection(string AccountApiUrl, string ApiKey)
        {
            if (string.IsNullOrEmpty(AccountApiUrl))
            {
                throw new ArgumentException("The reseller or customer API URL was not specified", nameof(AccountApiUrl));
            }

            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new ArgumentException("The API key was not specified", nameof(ApiKey));
            }

            //Make sure AccountApiUrl doesn't end with a slash
            this.AccountApiUrl = AccountApiUrl.TrimEnd('/');

            this.ApiKey = ApiKey;

            _baseAddress = $"{this.AccountApiUrl}/api/3";
            _lazyWebClient = new Lazy<WebClient>(() => new WebClient());

            //Set headers
            this.WebClient.Headers.Add("Api-Token", ApiKey);
        }

        public ActiveCampaignResult<object> GetLinkedData(Uri LinkUrl)
        {
            var linkedUrl = LinkUrl.ToString();

            //get result
            var result = this.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<TResult> GetLinkedData<TResult>(Uri LinkUrl)
        {
            var linkedUrl = LinkUrl.ToString();

            //get result
            var result = this.ExecuteGetRequest<TResult>(linkedUrl);
            return result;
        }

        internal ActiveCampaignResult<TResult> ExecuteGetRequest<TResult>(string Action, ActiveCampaignRequest<TResult> RequestData)
        {
            string urlAction;
            var json = "";

            var queryParameters = GetQueryString(Action, RequestData);
            if (!string.IsNullOrEmpty(queryParameters))
            {
                urlAction = $"{_baseAddress}/{Action}/?{queryParameters}";
            }
            else
            {
                urlAction = $"{_baseAddress}/{Action}";
            }

            try
            {
                using (WebClient client = this.WebClient)
                {
                    json = client.DownloadString(urlAction);
                }
            }
            catch (Exception e)
            {
                HandleWebClientError(e, typeof(TResult));
            }

            var result = FormatResult<TResult>(urlAction, json);

            return result;
        }

        internal ActiveCampaignResult<TResult> ExecuteGetRequest<TResult>(string RequestUrl)
        {
            //var queryParameters = GetQueryString(action, requestData);
            var json = "";
            var urlAction = RequestUrl; //$"{baseAddress}/{action}/?{queryParameters}";

            try
            {
                using (WebClient client = this.WebClient)
                {
                    json = client.DownloadString(urlAction);
                }
            }
            catch (Exception e)
            {
                HandleWebClientError(e, typeof(TResult));
            }

            var result = FormatResult<TResult>(urlAction, json);

            return result;
        }

        internal ActiveCampaignResult<TResult> ExecutePostRequest<TResult>(string Action, ActiveCampaignRequest<TResult> RequestData)
        {
            var urlAction = $"{_baseAddress}/{Action}";
            var actionUri = new Uri(urlAction);

            var requestData = RequestData.SerializePostData();

            string jsonResponse = "";

            try
            {
                using (WebClient client = this.WebClient)
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    jsonResponse = client.UploadString(actionUri, "POST", requestData);
                }
            }
            catch (Exception e)
            {
                HandleWebClientError(e, typeof(TResult));
            }

            var result = FormatResult<TResult>(urlAction, jsonResponse);

            return result;
        }

        private static ActiveCampaignResult<TResult> FormatResult<TResult>(string action, string json)
        {
            var result = new ActiveCampaignResult<TResult>();
            result.RequestUrl = action;
            result.ResponseJson = json;

            //First see if it is a response message
            var response = JsonConvertWrapper.DeserializeObject<ActiveCampaignResponse>(json);
            if (!string.IsNullOrEmpty(response.ResultOutput))
            {
                result.Response = response;
                var dataJson = response.ResultOutput;
                var objectData = JsonConvertWrapper.DeserializeObject<TResult>(dataJson);
                result.ResultData = objectData;
            }
            else
            {
                //it's just the data object returned
                result.Response = null;
                var objectData = JsonConvertWrapper.DeserializeObject<TResult>(json);
                result.ResultData = objectData;
            }

            return result;
        }

        private string GetQueryString<TRequest>(string Action, ActiveCampaignRequest<TRequest> RequestData)
        {
            //SetRequestQueryValues(action, request);
            var filterParams = RequestData.ToQueryString().ToLower();

            var sideloadQs = "";
            var sideloadParamsList = RequestData.LinkedDataParams().ToList();
            if (sideloadParamsList.Any())
            {
                sideloadQs = $"include=" + string.Join(",", sideloadParamsList);
            }

            if (filterParams != "" && sideloadQs != "")
            {
                return filterParams + "&" + sideloadQs;
            }
            else
            {
                return filterParams + sideloadQs;
            }
        }

        private void HandleWebClientError(Exception e, Type RequestType)
        {
            var msg = $"Error making API request to ActiveCampaign Server";
            ActiveCampaignException.ExType type = ActiveCampaignException.ExType.Unspecified;

            if (e.Message.Contains("503"))
            {
                type = ActiveCampaignException.ExType.ApiServerError;
            }

            throw new ActiveCampaignException(msg, type, RequestType.ToString(), e);
        }

        public void Dispose()
        {
            if (!_lazyWebClient.IsValueCreated)
            {
                return;
            }

            _lazyWebClient.Value.Dispose();
        }
    }
}