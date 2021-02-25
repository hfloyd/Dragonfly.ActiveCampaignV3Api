namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ContactAutomationEntryCounts
    {
        [JsonProperty("automationEntryCounts")]
        public List<AutomationEntryCount> Data { get; set; }
    }

    public class AutomationEntryCount
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("hidden")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Hidden { get; set; }

        [JsonProperty("contactEntryCount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactEntryCount { get; set; }
    }
}