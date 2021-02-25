namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public class ContactAutomation
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("automation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long AutomationId { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("startid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long StartId { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("batchid")]
        public BatchId BatchId { get; set; }

        [JsonProperty("adddate")]
        public DateTimeOffset AddDate { get; set; }

        [JsonProperty("remdate")]
        public DateTimeOffset RemDate { get; set; }

        [JsonProperty("timespan")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Timespan { get; set; }

        [JsonProperty("lastblock")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LastBlock { get; set; }

        [JsonProperty("lastlogid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LastLogId { get; set; }

        [JsonProperty("lastdate")]
        public DateTimeOffset LastDate { get; set; }

        [JsonProperty("in_als")]
        public object InAls { get; set; }

        [JsonProperty("completedElements")]
        public long CompletedElements { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("completed")]
        public long Completed { get; set; }

        [JsonProperty("completeValue")]
        public long CompleteValue { get; set; }

        [JsonProperty("links")]
        public ContactAutomationLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactGoalsList> GetContactGoals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactGoals.ToString();
            var result = Connection.ExecuteGetRequest<ContactGoalsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactAutomationLogsList> GetAutomationLogs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AutomationLogs.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomationLogsList>(linkedUrl);
            return result;
        }
        
        #endregion

    }

    public class ContactAutomationLinks
    {
        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("contactGoals")]
        public Uri ContactGoals { get; set; }

        [JsonProperty("automationLogs")]
        public Uri AutomationLogs { get; set; }
    }

}

