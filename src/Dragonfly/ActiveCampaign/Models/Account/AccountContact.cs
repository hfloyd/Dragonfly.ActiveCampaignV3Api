namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    public class AccountContact
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("account")]
        public long Account { get; set; }

        [JsonProperty("contact")]
        public long Contact { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("createdTimestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("links")]
        public AccountContactLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Account> GetAccount(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Account.ToString();
            var result = Connection.ExecuteGetRequest<Account>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }

        #endregion
    }

    public class AccountContactLinks
    {
        [JsonProperty("account")]
        public Uri Account { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }
    }
}