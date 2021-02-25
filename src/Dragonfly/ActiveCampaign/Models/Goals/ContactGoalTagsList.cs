namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ContactGoalTagsList
    {
        //TODO: HOLD - Needs more JSON examples for ContactGoalTags
        [JsonProperty("contactGoalTags")]
        public List<object> ContactGoalTags { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

}