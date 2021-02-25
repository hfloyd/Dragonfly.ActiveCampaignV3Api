namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ContactFieldValues
    {
        [JsonProperty("fieldValues")]
        public List<FieldValue> Data { get; set; }
    }

}