namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ContactTag
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("tag")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TagId { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("links")]
        public ContactTagLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Tag> GetTag(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Tag.ToString();
            var result = Connection.ExecuteGetRequest<Tag>(linkedUrl);
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

    public class ContactTagLinks
    {
        [JsonProperty("tag")]
        public Uri Tag { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }
    }
}
