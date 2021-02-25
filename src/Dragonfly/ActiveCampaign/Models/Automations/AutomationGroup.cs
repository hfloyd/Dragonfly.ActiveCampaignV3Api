namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AutomationGroup
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("automation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Automation { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("links")]
        public AutomationGroupLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        #endregion
    }

    public  class AutomationGroupLinks
    {
        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("group")]
        public Uri Group { get; set; }
    }
}
