namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ContactAutomationLog
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("automation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Automation { get; set; }

        [JsonProperty("block")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Block { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Contact { get; set; }

        [JsonProperty("contactAutomation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactAutomation { get; set; }
        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("blockid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BlockId { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberId { get; set; }

        [JsonProperty("contactseriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactSeriesId { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("res")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Res { get; set; }

        [JsonProperty("links")]
        public ContactAutomationLogLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationBlock> GetBlock(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Block.ToString();
            var result = Connection.ExecuteGetRequest<AutomationBlock>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactAutomation> GetContactAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactAutomation.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomation>(linkedUrl);
            return result;
        }

        #endregion


    }

    public class ContactAutomationLogLinks
    {
        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("block")]
        public Uri Block { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("contactAutomation")]
        public Uri ContactAutomation { get; set; }
    }
}
