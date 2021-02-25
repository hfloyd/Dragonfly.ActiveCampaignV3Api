namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ScoreCalcHistory
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("score_id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ScoreId { get; set; }

        [JsonProperty("last_subscriber_id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LastSubscriberId { get; set; }

        [JsonProperty("last_complete")]
        public DateTimeOffset LastComplete { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("links")]
        public ScoreCalcHistoryLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Score> GetScore(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Score.ToString();
            var result = Connection.ExecuteGetRequest<Score>(linkedUrl);
            return result;
        }

        #endregion
    }

    public class ScoreCalcHistoryLinks
    {
        [JsonProperty("score")]
        public Uri Score { get; set; }
    }
}