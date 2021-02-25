namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Note
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }
        
        [JsonProperty("note")]
        public string NoteText { get; set; }

        [JsonProperty("relid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long RelId { get; set; }

        [JsonProperty("reltype")]
        public string RelType { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("is_draft")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long IsDraft { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("links")]
        public NoteLinks Links { get; set; }
        
        #region Linked Data Methods

        public ActiveCampaignResult<ActivitiesList> GetActivities(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Activities.ToString();
            var result = Connection.ExecuteGetRequest<ActivitiesList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<MentionsList> GetMentions(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Mentions.ToString();
            var result = Connection.ExecuteGetRequest<MentionsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<NotesList> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<NotesList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<Owner> GetOwner(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Owner.ToString();
            var result = Connection.ExecuteGetRequest<Owner>(linkedUrl);
            return result;
        }
        #endregion

    }

    public class NoteLinks
    {
        [JsonProperty("activities")]
        public Uri Activities { get; set; }

        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("mentions")]
        public Uri Mentions { get; set; }

        [JsonProperty("notes")]
        public Uri Notes { get; set; }

        [JsonProperty("owner")]
        public Uri Owner { get; set; }
    }

}
