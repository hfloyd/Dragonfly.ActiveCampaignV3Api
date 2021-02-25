namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ContactTagsList
    {
        [JsonProperty("contactTags")]
        public List<ContactTag> Data { get; set; }
    }

}