namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class AddressGroupsList
    {

        //TODO: HOLD - Needs more JSON examples for AddressGroups
        [JsonProperty("addressGroups")]
        public List<object> AddressGroups { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

  
}