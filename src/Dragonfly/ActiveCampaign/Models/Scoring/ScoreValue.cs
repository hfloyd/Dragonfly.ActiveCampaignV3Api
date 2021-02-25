namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ScoreValue
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("score")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ScoreId { get; set; }

        [JsonProperty("scoreValue")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Value { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("deal")]
        public object Deal { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("links")]
        public ScoreValueLinks Links { get; set; }


        #region Linked Data Methods

        public ActiveCampaignResult<Score> GetScore(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Score.ToString();
            var result = Connection.ExecuteGetRequest<Score>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Deal> GetDeal(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Deal.ToString();
            var result = Connection.ExecuteGetRequest<Deal>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class ScoreValueLinks
    {
        [JsonProperty("score")]
        public Uri Score { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("deal")]
        public Uri Deal { get; set; }
    }
}
