namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AccountCustomFieldDatum
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("accountCustomFieldMetumId")]
        public long AccountCustomFieldMetumId { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("customFieldId")]
        public long CustomFieldId { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("createdTimestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }
        
        [JsonProperty("links")]
        public AccountCustomFieldDatumLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Account> GetAccount(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Account.ToString();
            var result = Connection.ExecuteGetRequest<Account>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AccountCustomFieldMetum> GetAccountCustomFieldMetum(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AccountCustomFieldMetum.ToString();
            var result = Connection.ExecuteGetRequest<AccountCustomFieldMetum>(linkedUrl);
            return result;
        }
        #endregion
    }

    public  class AccountCustomFieldDatumLinks
    {
        [JsonProperty("account")]
        public Uri Account { get; set; }

        [JsonProperty("accountCustomFieldMetum")]
        public Uri AccountCustomFieldMetum { get; set; }
    }
}
