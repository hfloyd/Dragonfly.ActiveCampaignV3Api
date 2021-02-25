namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class BounceLog
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset TimeStamp { get; set; }

        [JsonProperty("bounce")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Bounce { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Contact { get; set; }

        [JsonProperty("campaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Campaign { get; set; }

        [JsonProperty("message")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Message { get; set; }

        [JsonProperty("code")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Code { get; set; }

        [JsonProperty("bounceid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BounceId { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberId { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MessageId { get; set; }

        [JsonProperty("codeid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CodeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("links")]
        public BounceLogLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Bounce> GetBounce(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Bounce.ToString();
            var result = Connection.ExecuteGetRequest<Bounce>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Campaign> GetCampaign(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Campaign.ToString();
            var result = Connection.ExecuteGetRequest<Campaign>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Message> GetMessage(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Message.ToString();
            var result = Connection.ExecuteGetRequest<Message>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<BounceCodeResult> GetCode(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Code.ToString();
            var result = Connection.ExecuteGetRequest<BounceCodeResult>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class BounceLogLinks
    {
        [JsonProperty("bounce")]
        public Uri Bounce { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("campaign")]
        public Uri Campaign { get; set; }

        [JsonProperty("message")]
        public Uri Message { get; set; }

        [JsonProperty("code")]
        public Uri Code { get; set; }
    }
}
