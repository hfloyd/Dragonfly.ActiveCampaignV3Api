namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class BounceCodesList
    {
        [JsonProperty("results")]
        public List<BounceCodeResult> Results { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

   
}