namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public  class DealCustomFieldDatum
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("dealCustomFieldMetumId")]
        public long DealCustomFieldMetumId { get; set; }

        [JsonProperty("dealId")]
        public long DealId { get; set; }

        [JsonProperty("customFieldId")]
        public long CustomFieldId { get; set; }

        [JsonProperty("createdTimestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("links")]
        public DealCustomFieldDatumLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Deal> GetDeal(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Deal.ToString();
            var result = Connection.ExecuteGetRequest<Deal>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealCustomFieldMetum> GetDealCustomFieldMetum(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealCustomFieldMetum.ToString();
            var result = Connection.ExecuteGetRequest<DealCustomFieldMetum>(linkedUrl);
            return result;
        }

        #endregion
    }

    public  class DealCustomFieldDatumLinks
    {
        [JsonProperty("deal")]
        public Uri Deal { get; set; }

        [JsonProperty("dealCustomFieldMetum")]
        public Uri DealCustomFieldMetum { get; set; }
    }
}
