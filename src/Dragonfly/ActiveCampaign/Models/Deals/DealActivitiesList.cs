﻿namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for DealActivities
    public class DealActivitiesList
    {
        [JsonProperty("dealActivities")]
        public List<object> DealActivities { get; set; }
    }
}