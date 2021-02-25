namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AutomationBlock
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("automation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Automation { get; set; }

        [JsonProperty("parent")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Parent { get; set; }

        [JsonProperty("ordernum")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OrderNum { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("params")]
        public AutomationBlockParams Params { get; set; }

        [JsonProperty("deleted")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Deleted { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("links")]
        public AutomationBlockLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationBlock> GetParent(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Parent.ToString();
            var result = Connection.ExecuteGetRequest<AutomationBlock>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationBlocksList> GetChildren(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Children.ToString();
            var result = Connection.ExecuteGetRequest<AutomationBlocksList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactAutomationLogsList> GetContactAutomationLogs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactAutomationLogs.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomationLogsList>(linkedUrl);
            return result;
        }

        //TODO: HOLD - Needs more JSON examples for Goal
        public ActiveCampaignResult<object> GetGoal(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Goal.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
    
        #endregion

    }

    public class AutomationBlockLinks
    {
        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("parent")]
        public Uri Parent { get; set; }

        [JsonProperty("children")]
        public Uri Children { get; set; }

        [JsonProperty("contactAutomationLogs")]
        public Uri ContactAutomationLogs { get; set; }

        [JsonProperty("goal")]
        public Uri Goal { get; set; }
    }

    public class AutomationBlockParams
    {
        [JsonProperty("starts", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> Starts { get; set; }

        [JsonProperty("campaignid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodingChoiceConverter))]
        public long? CampaignId { get; set; }

        [JsonProperty("sendtype", NullValueHandling = NullValueHandling.Ignore)]
        public SendType? SendType { get; set; }

        [JsonProperty("waittype", NullValueHandling = NullValueHandling.Ignore)]
        public WaitType? WaitType { get; set; }

        [JsonProperty("waittime", NullValueHandling = NullValueHandling.Ignore)]
        public long? WaitTime { get; set; }

        [JsonProperty("waitdurt", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitDuration { get; set; }

        [JsonProperty("timelimit", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeLimit { get; set; }

        [JsonProperty("uptotime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpToTime { get; set; }

        [JsonProperty("uptodurt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpToDuration { get; set; }

        [JsonProperty("segmentid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodingChoiceConverter))]
        public long? SegmentId { get; set; }

        [JsonProperty("frommail", NullValueHandling = NullValueHandling.Ignore)]
        public string FromMail { get; set; }

        [JsonProperty("fromname", NullValueHandling = NullValueHandling.Ignore)]
        public string FromName { get; set; }

        [JsonProperty("tomail", NullValueHandling = NullValueHandling.Ignore)]
        public string ToMail { get; set; }

        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("defaultfromemail", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultFromEmail { get; set; }

        [JsonProperty("defaultfromname", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultFromName { get; set; }

        [JsonProperty("customfieldsection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomFieldSection { get; set; }

        [JsonProperty("if1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodingChoiceConverter))]
        public long? If1 { get; set; }

        [JsonProperty("if0", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodingChoiceConverter))]
        public long? If0 { get; set; }

        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public long? End { get; set; }

        [JsonProperty("updatefield", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateField { get; set; }

        [JsonProperty("updatevalue", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateValue { get; set; }

        [JsonProperty("updatedate", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateDate { get; set; }

        [JsonProperty("goto", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoTo { get; set; }

        [JsonProperty("scoreid", NullValueHandling = NullValueHandling.Ignore)]
        public long? ScoreId { get; set; }

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public long? Points { get; set; }

        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expire { get; set; }

        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set { get; set; }

        [JsonProperty("tagNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagNames { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("seriesid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> SeriesId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pipeline { get; set; }

        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stage { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public long? Owner { get; set; }

        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public long? Task { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("affect", NullValueHandling = NullValueHandling.Ignore)]
        public string Affect { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public long? Group { get; set; }

        [JsonProperty("deal_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? DealGroupId { get; set; }

        [JsonProperty("assignee_username", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneeUsername { get; set; }

        [JsonProperty("trigger_start", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerStart { get; set; }

        [JsonProperty("trigger_when", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerWhen { get; set; }
    }
}
