namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class PlusAppend
    {

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("last_updated_rapleaf")]
        public object LastUpdatedRapleaf { get; set; }

        [JsonProperty("last_updated_fliptop")]
        public object LastUpdatedFliptop { get; set; }

        [JsonProperty("last_updated_fullcontact")]
        public object LastUpdatedFullContact { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("membershipsFacebook")]
        public Uri MembershipsFacebook { get; set; }

        [JsonProperty("membershipsTwitter")]
        public Uri MembershipsTwitter { get; set; }

        [JsonProperty("membershipsLinkedin")]
        public Uri MembershipsLinkedIn { get; set; }

        [JsonProperty("links")]
        public PlusAppendLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class PlusAppendLinks
    {
        [JsonProperty("contact")]
        public Uri Contact { get; set; }
    }
}
