namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AccountCustomFieldDataList
    {
        [JsonProperty("accountCustomFieldData")]
        public List<AccountCustomFieldDatum> AccountCustomFieldData { get; set; }
    }

}