namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public class DealCustomFieldMetum
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("fieldLabel")]
        public string FieldLabel { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldOptions")]
        public object FieldOptions { get; set; }

        [JsonProperty("fieldDefault")]
        public string FieldDefault { get; set; }

        [JsonProperty("isFormVisible")]
        public long IsFormVisible { get; set; }

        [JsonProperty("isRequired")]
        public long IsRequired { get; set; }

        [JsonProperty("displayOrder")]
        public long DisplayOrder { get; set; }

        [JsonProperty("createdTimestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("links")]
        public DealCustomFieldMetumLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<DealCustomFieldDataList> GetDealCustomFieldData(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealCustomFieldData.ToString();
            var result = Connection.ExecuteGetRequest<DealCustomFieldDataList>(linkedUrl);
            return result;
        }

        #endregion
    }

    public class DealCustomFieldMetumLinks
    {
        [JsonProperty("dealCustomFieldData")]
        public Uri DealCustomFieldData { get; set; }
    }
}