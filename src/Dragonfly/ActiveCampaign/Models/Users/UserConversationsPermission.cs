namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class UserConversationsPermission
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("permission")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Permission { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("links")]
        public UserConversationsPermissionLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class UserConversationsPermissionLinks
    {
        [JsonProperty("user")]
        public Uri User { get; set; }
    }
}
