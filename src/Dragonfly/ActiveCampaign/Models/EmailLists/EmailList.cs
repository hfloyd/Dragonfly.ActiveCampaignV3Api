
namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class EmailList
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stringid")]
        public string StringId { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }


        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("p_use_tracking")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseTracking { get; set; }

        [JsonProperty("p_use_analytics_read")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseAnalyticsRead { get; set; }

        [JsonProperty("p_use_analytics_link")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseAnalyticsLink { get; set; }

        [JsonProperty("p_use_twitter")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseTwitter { get; set; }

        [JsonProperty("p_use_facebook")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseFacebook { get; set; }

        [JsonProperty("p_embed_image")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PEmbedImage { get; set; }

        [JsonProperty("p_use_captcha")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PUseCaptcha { get; set; }

        [JsonProperty("send_last_broadcast")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SendLastBroadcast { get; set; }

        [JsonProperty("private")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Private { get; set; }

        [JsonProperty("analytics_domains")]
        public string AnalyticsDomains { get; set; }

        [JsonProperty("analytics_source")]
        public string AnalyticsSource { get; set; }

        [JsonProperty("analytics_ua")]
        public string AnalyticsUa { get; set; }

        [JsonProperty("twitter_token")]
        public string TwitterToken { get; set; }

        [JsonProperty("twitter_token_secret")]
        public string TwitterTokenSecret { get; set; }

        [JsonProperty("facebook_session")]
        public string FacebookSession { get; set; }

        [JsonProperty("carboncopy")]
        public string CarbonCopy { get; set; }

        [JsonProperty("subscription_notify")]
        public string SubscriptionNotify { get; set; }

        [JsonProperty("unsubscription_notify")]
        public string UnsubscriptionNotify { get; set; }

        [JsonProperty("require_name")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long RequireName { get; set; }

        [JsonProperty("get_unsubscribe_reason")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GetUnsubscribeReason { get; set; }

        [JsonProperty("to_name")]
        public string ToName { get; set; }

        [JsonProperty("optinoptout")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OptinOptout { get; set; }

        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("sender_addr1")]
        public string SenderAddr1 { get; set; }

        [JsonProperty("sender_addr2")]
        public string SenderAddr2 { get; set; }

        [JsonProperty("sender_city")]
        public string SenderCity { get; set; }

        [JsonProperty("sender_state")]
        public string SenderState { get; set; }

        [JsonProperty("sender_zip")]
        public string SenderZip { get; set; }

        [JsonProperty("sender_country")]
        public string SenderCountry { get; set; }

        [JsonProperty("sender_phone")]
        public string SenderPhone { get; set; }

        [JsonProperty("sender_url")]
        public Uri SenderUrl { get; set; }

        [JsonProperty("sender_reminder")]
        public string SenderReminder { get; set; }

        [JsonProperty("fulladdress")]
        public string FullAddress { get; set; }

        [JsonProperty("optinmessageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OptinMessageId { get; set; }

        [JsonProperty("optoutconf")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OptoutConf { get; set; }

        [JsonProperty("deletestamp")]
        public object Deletestamp { get; set; }

        [JsonProperty("udate")]
        public object UDate { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("links")]
        public EmailListLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<ContactGoalsList> GetContactGoalLists(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactGoalLists.ToString();
            var result = Connection.ExecuteGetRequest<ContactGoalsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AddressLists> GetAddressLists(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AddressLists.ToString();
            var result = Connection.ExecuteGetRequest<AddressLists>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params for EmaiListRequest?
        //public enum LinkedData
        //{
        //    BounceLogs,

        //}

        //internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<XX.LinkedData> DataList)
        //{
        //    var list = new List<string>();

        //    foreach (var item in DataList)
        //    {
        //        switch (item)
        //        {
        //            case LinkedData.BounceLogs:
        //                list.Add("bounceLogs");
        //                break;

        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }

        //    return list;
        //}

        #endregion
    }

    public class EmailListLinks
    {
        [JsonProperty("contactGoalLists")]
        public Uri ContactGoalLists { get; set; }

        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("addressLists")]
        public Uri AddressLists { get; set; }
    }
}
