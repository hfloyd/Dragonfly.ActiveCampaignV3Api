namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Tag
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("tagType")]
        public string TagType { get; set; }

        [JsonProperty("tag")]
        public string TagName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subscriber_count")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberCount { get; set; }

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
        public TagLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<ContactGoalTagsList> GetContactGoalTags(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactGoalTags.ToString();
            var result = Connection.ExecuteGetRequest<ContactGoalTagsList>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class TagLinks
    {
        [JsonProperty("contactGoalTags")]
        public Uri ContactGoalTags { get; set; }
    }
}
