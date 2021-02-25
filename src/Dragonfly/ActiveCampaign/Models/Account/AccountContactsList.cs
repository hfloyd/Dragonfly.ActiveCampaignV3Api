namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class AccountContactsList
    {
        [JsonProperty("AccountContacts")]
        public List<AccountContact> AccountContacts { get; set; }
    }
}