namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using Newtonsoft.Json;

    public class Automation
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        //public long Status { get; set; }
        public AutomationStatus Status { get; set; }

        [JsonProperty("entered")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Entered { get; set; }

        [JsonProperty("exited")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Exited { get; set; }

        [JsonProperty("hidden")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Hidden { get; set; }

        [JsonProperty("links")]
        public AutomationLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<CampaignsList> GetCampaigns(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Campaigns.ToString();
            var result = Connection.ExecuteGetRequest<CampaignsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactGoalsList> GetContactGoals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactGoals.ToString();
            var result = Connection.ExecuteGetRequest<ContactGoalsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactAutomationsList> GetContactAutomations(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactAutomations.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomationsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationBlocksList> GetBlocks(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Blocks.ToString();
            var result = Connection.ExecuteGetRequest<AutomationBlocksList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<GoalsList> GetGoals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Goals.ToString();
            var result = Connection.ExecuteGetRequest<GoalsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<SmsList> GetSms(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Sms.ToString();
            var result = Connection.ExecuteGetRequest<SmsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<SiteMessageList> GetSiteMessages(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.SiteMessages.ToString();
            var result = Connection.ExecuteGetRequest<SiteMessageList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationTriggersList> GetTriggers(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Triggers.ToString();
            var result = Connection.ExecuteGetRequest<AutomationTriggersList>(linkedUrl);
            return result;
        }
       
        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params for AutomationRequest?
        //public enum LinkedData
        //{
        //    BounceLogs,

        //}

        //internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<XX.LinkedData> DataList)
        //{
        //    var list = new List<string>();

        //    foreach (var item in DataList)
        //    {
        //        switch (item)
        //        {
        //            case LinkedData.BounceLogs:
        //                list.Add("bounceLogs");
        //                break;

        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }

        //    return list;
        //}

        #endregion
    }

    public  class AutomationLinks
    {
        [JsonProperty("campaigns")]
        public Uri Campaigns { get; set; }

        [JsonProperty("contactGoals")]
        public Uri ContactGoals { get; set; }

        [JsonProperty("contactAutomations")]
        public Uri ContactAutomations { get; set; }

        [JsonProperty("blocks")]
        public Uri Blocks { get; set; }

        [JsonProperty("goals")]
        public Uri Goals { get; set; }

        [JsonProperty("sms")]
        public Uri Sms { get; set; }

        [JsonProperty("sitemessages")]
        public Uri SiteMessages { get; set; }

        [JsonProperty("triggers")]
        public Uri Triggers { get; set; }
    }
   
}