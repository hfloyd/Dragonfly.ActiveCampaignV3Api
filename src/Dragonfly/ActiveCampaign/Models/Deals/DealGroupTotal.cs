namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class DealGroupTotal
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("dealGroup")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long DealGroup { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("d_groupid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long DGroupId { get; set; }

        [JsonProperty("total")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Total { get; set; }

        [JsonProperty("value")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Value { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("links")]
        public DealGroupTotalLinks Links { get; set; }

        #region Linked Data Methods
        
        //TODO: HOLD - Needs more JSON examples for DealGroup
        public ActiveCampaignResult<object> GetDealGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealGroup.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
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

    public class DealGroupTotalLinks
    {
        [JsonProperty("dealGroup")]
        public Uri DealGroup { get; set; }

        [JsonProperty("user")]
        public Uri User { get; set; }
    }
}
