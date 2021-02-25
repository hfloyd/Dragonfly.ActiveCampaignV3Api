namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ListGroupsList
    {
        [JsonProperty("listGroups")]
        public List<ListGroup> ListGroups { get; set; }
    }

}
