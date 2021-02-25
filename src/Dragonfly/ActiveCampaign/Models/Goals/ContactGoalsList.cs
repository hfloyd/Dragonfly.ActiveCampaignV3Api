namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Need JSON examples for ContactGoals
    public partial class ContactGoalsList
    {
        [JsonProperty("contactGoals")]
        public List<object> Data { get; set; }
    }

    
}

