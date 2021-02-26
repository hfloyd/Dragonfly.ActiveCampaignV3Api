namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class CalendarFeed
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("notification")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Notification { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("links")]
        public CalendarFeedLinks Links { get; set; }

        #region Linked Data Methods

        //TODO: HOLD - Update Linked Data Models
        public ActiveCampaignResult<object> GetCalendarRels(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CalendarRels.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<object> GetCalendarUsers(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CalendarUsers.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
        #endregion
    }

    public  class CalendarFeedLinks
    {
        [JsonProperty("calendarRels")]
        public Uri CalendarRels { get; set; }

        [JsonProperty("calendarUsers")]
        public Uri CalendarUsers { get; set; }
    }
}
