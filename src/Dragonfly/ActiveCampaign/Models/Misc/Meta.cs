using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragonfly.ActiveCampaign.Models
{
    using Newtonsoft.Json;

    public class Meta
    {
        [JsonProperty("total")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Total { get; set; }

        [JsonProperty("sortable")]
        public bool Sortable { get; set; }

        [JsonProperty("page_input")]
        public PageInput PageInput { get; set; }
    }

    public class PageInput
    {
        [JsonProperty("segmentid")]
        public long Segmentid { get; set; }

        [JsonProperty("formid")]
        public long Formid { get; set; }

        [JsonProperty("listid")]
        public long Listid { get; set; }

        [JsonProperty("tagid")]
        public long Tagid { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("search")]
        public object Search { get; set; }

        [JsonProperty("sort")]
        public object Sort { get; set; }

        [JsonProperty("seriesid")]
        public long Seriesid { get; set; }

        [JsonProperty("waitid")]
        public long Waitid { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("forceQuery")]
        public long ForceQuery { get; set; }

        [JsonProperty("cacheid")]
        public string Cacheid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
