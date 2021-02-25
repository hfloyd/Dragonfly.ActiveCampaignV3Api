namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Score
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("reltype")]
        public string RelType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descript")]
        public string Description { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("links")]
        public ScoreLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<ScoreCalcHistory> GetScoreCalcHistory(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ScoreCalcHistory.ToString();
            var result = Connection.ExecuteGetRequest<ScoreCalcHistory>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class ScoreLinks
    {
        [JsonProperty("scoreCalcHistory")]
        public Uri ScoreCalcHistory { get; set; }
    }
}
