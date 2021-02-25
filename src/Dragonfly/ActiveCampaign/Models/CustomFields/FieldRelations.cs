namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class FieldRelations
    {
        [JsonProperty("fieldRels")]
        public List<FieldRel> Data { get; set; }
    }

    public class FieldRel
    {
        [JsonProperty("field")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Field { get; set; }

        [JsonProperty("relid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long RelatedListId { get; set; }

        [JsonProperty("dorder")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Dorder { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }
    }
}

