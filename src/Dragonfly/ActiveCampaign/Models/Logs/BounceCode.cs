namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class BounceCode
    {
        [JsonProperty("result")]
        public BounceCodeResult Result { get; set; }
    }

    public class BounceCodeResult
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("descript")]
        public string Description { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

    }
}
