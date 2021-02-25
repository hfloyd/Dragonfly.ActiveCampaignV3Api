namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class FieldsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty("fieldOptions")]
        public List<FieldOption> FieldOptions { get; set; }

        [JsonProperty("fieldRels")]
        public List<FieldRel> FieldRelations { get; set; }

    }

 
}
