﻿namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ActivitiesList
    {
        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }
    }
}
