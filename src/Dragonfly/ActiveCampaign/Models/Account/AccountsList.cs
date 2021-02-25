namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public  class AccountsList
    {
        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }
    }

}