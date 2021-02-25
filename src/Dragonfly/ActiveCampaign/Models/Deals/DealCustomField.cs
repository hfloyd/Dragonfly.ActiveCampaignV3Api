namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class DealCustomField
    {
        [JsonProperty("customFieldId")]
        public long CustomFieldId { get; set; }

        [JsonProperty("fieldValue")]
        public FieldValue FieldValue { get; set; }

        [JsonProperty("dealId")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long DealId { get; set; }

        [JsonProperty("fieldCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldCurrency { get; set; }
    }
}
