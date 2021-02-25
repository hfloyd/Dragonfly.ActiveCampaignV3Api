namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class HyperLink
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("campaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Campaign { get; set; }

        [JsonProperty("message")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Message { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MessageId { get; set; }

        [JsonProperty("link")]
        public string LinkContent { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("tracked")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Tracked { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("uniquelinkclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueLinkClicks { get; set; }

        [JsonProperty("linkclicks")]
        public string LinkClicks { get; set; }

        [JsonProperty("links")]
        public HyperLinkLinks Links { get; set; }

        #region Linked Data Methods

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

        #endregion

  }

    public class HyperLinkLinks
    {
        [JsonProperty("campaign")]
        public Uri Campaign { get; set; }

        [JsonProperty("message")]
        public Uri Message { get; set; }
    }
}
