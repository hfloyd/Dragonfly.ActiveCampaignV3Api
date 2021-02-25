namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for DealConnections
    public class DealConnectionsList
    {
        [JsonProperty("dealConnections")]
        public List<object> DealConnections { get; set; }
    }
}