namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class BounceLogsList
    {
        [JsonProperty("bounceLogs")]
        public List<BounceLog> BounceLogs { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}

