namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class TrackingLog
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public Uri Value { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("links")]
        public TrackingLogLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class TrackingLogLinks
    {
        [JsonProperty("contact")]
        public Uri Contact { get; set; }
    }
}
