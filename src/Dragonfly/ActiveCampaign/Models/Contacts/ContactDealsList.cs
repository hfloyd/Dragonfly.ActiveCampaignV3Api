namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    public class ContactDealsList
    {
        [JsonProperty("contactDeals")]
        public List<ContactDeal> Data { get; set; }
    }
}