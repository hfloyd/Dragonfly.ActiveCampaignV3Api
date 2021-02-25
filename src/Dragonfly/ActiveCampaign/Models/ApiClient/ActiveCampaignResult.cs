namespace Dragonfly.ActiveCampaign.Models
{
    /// <summary>
    /// Result returned from an ActiveCampaign Request
    /// </summary>
    /// <typeparam name="T">Model of ResultData</typeparam>
    public class ActiveCampaignResult<T>
    {
        public ActiveCampaignResponse Response { get; set; }

        public string RequestUrl { get; set; }
        
        public T ResultData { get; set; }

        public string ResponseJson { get; set; }

        public override string ToString()
        {
            if (Response != null)
            {
                return $"{Response.ResultCode} - Message: {Response.ResultMessage} - Output: {Response.ResultOutput}";
            }
            else if (ResultData != null)
            {
                return $"{typeof(T).ToString()} : {ResultData.ToString()}";
            }
            else if (!string.IsNullOrEmpty(RequestUrl))
            {
                return RequestUrl;
            }
            else
            {
                return base.ToString();
            }
        }
    }
}