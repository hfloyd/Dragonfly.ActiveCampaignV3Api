namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ConfigsList
    {
        [JsonProperty("configs")]
        public List<Config> Configs { get; set; }
    }

}