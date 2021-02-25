namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class DealStage
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("cardRegion1")]
        public string CardRegion1 { get; set; }

        [JsonProperty("cardRegion2")]
        public string CardRegion2 { get; set; }

        [JsonProperty("cardRegion3")]
        public string CardRegion3 { get; set; }

        [JsonProperty("cardRegion4")]
        public string CardRegion4 { get; set; }

        [JsonProperty("cardRegion5")]
        public string CardRegion5 { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset Cdate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("dealOrder")]
        public string DealOrder { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("order")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Order { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset Udate { get; set; }

        [JsonProperty("width")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Width { get; set; }

        [JsonProperty("links")]
        public DealStageLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        #endregion
    }

    public partial class DealStageLinks
    {
        [JsonProperty("group")]
        public string Group { get; set; }
    }

}
