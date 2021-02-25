namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for DealGroupUsers
    public partial class DealGroupUsersList
    {
        [JsonProperty("dealGroupUsers")]
        public List<object> DealGroupUsers { get; set; }
    }
}