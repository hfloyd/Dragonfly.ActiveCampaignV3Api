namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for Task
    public class TasksList
    {
        [JsonProperty("tasks")]
        public List<object> Tasks { get; set; }
    }
}