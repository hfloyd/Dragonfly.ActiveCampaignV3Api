namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class UserGroupsList
    {
        [JsonProperty("userGroups")]
        public List<UserGroup> UserGroups { get; set; }
    }

}