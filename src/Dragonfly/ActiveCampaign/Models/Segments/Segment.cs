namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Segment
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logic")]
        public string Logic { get; set; }

        [JsonProperty("hidden")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Hidden { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

    }

}
