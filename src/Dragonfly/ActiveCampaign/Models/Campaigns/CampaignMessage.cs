namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class CampaignMessage
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("campaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Campaign { get; set; }

        [JsonProperty("message")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Message { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MessageId { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("percentage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Percentage { get; set; }

        [JsonProperty("sourcesize")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SourceSize { get; set; }

        [JsonProperty("send_amt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SendAmt { get; set; }

        [JsonProperty("total_amt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TotalAmt { get; set; }

        [JsonProperty("opens")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Opens { get; set; }

        [JsonProperty("uniqueopens")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueOpens { get; set; }

        [JsonProperty("linkclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LinkClicks { get; set; }

        [JsonProperty("uniquelinkclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueLinkClicks { get; set; }

        [JsonProperty("subscriberclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberClicks { get; set; }

        [JsonProperty("forwards")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Forwards { get; set; }

        [JsonProperty("uniqueforwards")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueForwards { get; set; }

        [JsonProperty("hardbounces")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long HardBounces { get; set; }

        [JsonProperty("softbounces")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SoftBounces { get; set; }

        [JsonProperty("unsubscribes")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Unsubscribes { get; set; }

        [JsonProperty("unsubreasons")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UnsubReasons { get; set; }

        [JsonProperty("updates")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Updates { get; set; }

        [JsonProperty("socialshares")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SocialShares { get; set; }

        [JsonProperty("replies")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Replies { get; set; }

        [JsonProperty("uniquereplies")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueReplies { get; set; }

        [JsonProperty("spamcheck_score")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SpamcheckScore { get; set; }

        [JsonProperty("spamcheck_max")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SpamcheckMax { get; set; }

        [JsonProperty("initial_split_percentage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long InitialSplitPercentage { get; set; }

        [JsonProperty("screenshot")]
        public string Screenshot { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("links")]
        public CampaignMessageLinks Links { get; set; }

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

    public class CampaignMessageLinks
    {
        [JsonProperty("campaign")]
        public Uri Campaign { get; set; }

        [JsonProperty("message")]
        public Uri Message { get; set; }
    }
}
