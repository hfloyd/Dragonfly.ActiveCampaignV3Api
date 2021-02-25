namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for AggregateRevenues
    public class AggregateRevenuesList
    {
        [JsonProperty("aggregateRevenues")]
        public List<object> AggregateRevenues { get; set; }
    }
}