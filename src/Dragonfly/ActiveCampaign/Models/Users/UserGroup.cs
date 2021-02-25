namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class UserGroup
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("groupid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GroupId { get; set; }

        [JsonProperty("cdate")]
        public object CDate { get; set; }

        [JsonProperty("udate")]
        public object UDate { get; set; }

        [JsonProperty("links")]
        public UserGroupLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class UserGroupLinks
    {
        [JsonProperty("group")]
        public Uri Group { get; set; }

        [JsonProperty("user")]
        public Uri User { get; set; }
    }
}
