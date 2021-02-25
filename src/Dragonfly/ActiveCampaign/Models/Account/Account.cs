namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Account
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountUrl")]
        public Uri AccountUrl { get; set; }

        [JsonProperty("contactCount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactCount { get; set; }

        [JsonProperty("dealCount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long DealCount { get; set; }

        [JsonProperty("createdTimestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("links")]
        public AccountLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<NotesList> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<NotesList>(linkedUrl);
            return result;
        }

       public ActiveCampaignResult<AccountCustomFieldDataList> GetAccountCustomFieldData(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AccountCustomFieldData.ToString();
            var result = Connection.ExecuteGetRequest<AccountCustomFieldDataList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AccountContactsList> GetAccountContacts(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AccountContacts.ToString();
            var result = Connection.ExecuteGetRequest<AccountContactsList>(linkedUrl);
            return result;
        }

        #endregion
    }

    public class AccountLinks
    {
        [JsonProperty("notes")]
        public Uri Notes { get; set; }

        [JsonProperty("accountCustomFieldData")]
        public Uri AccountCustomFieldData { get; set; }

        [JsonProperty("accountContacts")]
        public Uri AccountContacts { get; set; }
    }
}
