namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Activity
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("subscriberid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberId { get; set; }

        [JsonProperty("reference_type")]
        public string ReferenceType { get; set; }

        [JsonProperty("reference_id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ReferenceId { get; set; }

        [JsonProperty("reference_action")]
        public string ReferenceAction { get; set; }

        [JsonProperty("jsonData")]
        public object JsonData { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("referenceModelName")]
        public string ReferenceModelName { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("reference")]
        public Reference Reference { get; set; }

        [JsonProperty("links")]
        public ActivityLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ActivityRecipientsList> GetRecipients(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Recipients.ToString();
            var result = Connection.ExecuteGetRequest<ActivityRecipientsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Reference> GetReference(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Reference.ToString();
            var result = Connection.ExecuteGetRequest<Reference>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<NotesList> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<NotesList>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class ActivityLinks
    {
        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("recipients")]
        public Uri Recipients { get; set; }

        [JsonProperty("reference")]
        public Uri Reference { get; set; }

        [JsonProperty("notes")]
        public Uri Notes { get; set; }
    }

}
