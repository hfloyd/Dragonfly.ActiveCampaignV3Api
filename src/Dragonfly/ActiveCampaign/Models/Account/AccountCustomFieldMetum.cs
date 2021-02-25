namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public  class AccountCustomFieldMetum
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
        public AccountCustomFieldMetumLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<AccountCustomFieldDataList> GetAccountCustomFieldData(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AccountCustomFieldData.ToString();
            var result = Connection.ExecuteGetRequest<AccountCustomFieldDataList>(linkedUrl);
            return result;
        }

        #endregion
    }

    public  class AccountCustomFieldMetumLinks
    {
        [JsonProperty("accountCustomFieldData")]
        public Uri AccountCustomFieldData { get; set; }
    }
}