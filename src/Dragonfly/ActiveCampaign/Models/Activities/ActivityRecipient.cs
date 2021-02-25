namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ActivityRecipient
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("recipient")]
        public Recipient Recipient { get; set; }

        [JsonProperty("activity")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Activity { get; set; }

        [JsonProperty("reltype")]
        public string Reltype { get; set; }

        [JsonProperty("relid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Relid { get; set; }

        [JsonProperty("activityid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Activityid { get; set; }

        [JsonProperty("links")]
        public ActivityRecipientLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Recipient> GetRecipient(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Recipient.ToString();
            var result = Connection.ExecuteGetRequest<Recipient>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<Activity> GetActivity(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Activity.ToString();
            var result = Connection.ExecuteGetRequest<Activity>(linkedUrl);
            return result;
        }

        #endregion


    }

    public class ActivityRecipientLinks
    {
        [JsonProperty("recipient")]
        public Uri Recipient { get; set; }

        [JsonProperty("activity")]
        public Uri Activity { get; set; }
    }

  
}
