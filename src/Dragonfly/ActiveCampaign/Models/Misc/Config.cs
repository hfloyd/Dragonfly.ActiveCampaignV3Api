namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Config
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("owner")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Owner { get; set; }

        [JsonProperty("keyname")]
        public string KeyName { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("val")]
        public string Val { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset? CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset? UDate { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? UpdatedBy { get; set; }

        [JsonProperty("links")]
        public ConfigLinks Links { get; set; }


        #region Linked Data Methods
        
        public ActiveCampaignResult<Owner> GetOwner(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Owner.ToString();
            var result = Connection.ExecuteGetRequest<Owner>(linkedUrl);
            return result;
        }

        #endregion
        
    }

    public class ConfigLinks
    {
        [JsonProperty("owner")]
        public Uri Owner { get; set; }
    }
}
