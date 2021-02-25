namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for DealGroupGroups
    public class DealGroupGroupsList
    {
        [JsonProperty("dealGroupGroups")]
        public List<object> DealGroupGroups { get; set; }
    }
}