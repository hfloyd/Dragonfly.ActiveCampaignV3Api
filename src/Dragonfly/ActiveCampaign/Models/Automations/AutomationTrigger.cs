namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AutomationTrigger
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("segmentid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SegmentId { get; set; }

        [JsonProperty("multientry")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MultiEntry { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long RelId { get; set; }

        [JsonProperty("params")]
        public AutomationTriggerParams Params { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }
        
    }

    public class AutomationTriggerParams
    {
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        [JsonProperty("listid", NullValueHandling = NullValueHandling.Ignore)]
        public long? ListId { get; set; }

        [JsonProperty("linkid", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinkId { get; set; }

        [JsonProperty("segueid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SegueId { get; set; }

        [JsonProperty("urldomain", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlDomain { get; set; }

        [JsonProperty("urlpath", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("scoreop", NullValueHandling = NullValueHandling.Ignore)]
        public string ScoreOp { get; set; }

        [JsonProperty("scorevalue", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? ScoreValue { get; set; }
    }
}
