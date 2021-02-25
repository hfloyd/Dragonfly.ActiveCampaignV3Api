namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

   public class ContactEmailList
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("list")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ListId { get; set; }

        [JsonProperty("form")]
        public object Form { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("sdate")]
        public DateTimeOffset SDate { get; set; }

        [JsonProperty("udate")]
        public object UDate { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("responder")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Responder { get; set; }

        [JsonProperty("sync")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Sync { get; set; }

        [JsonProperty("unsubreason")]
        public string UnSubscribeReason { get; set; }

        [JsonProperty("campaign")]
        public object Campaign { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("ip4Sub")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4Sub { get; set; }

        [JsonProperty("sourceid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SourceId { get; set; }

        [JsonProperty("autosyncLog")]
        public object AutosyncLog { get; set; }

        [JsonProperty("ip4_last")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4Last { get; set; }

        [JsonProperty("ip4Unsub")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4Unsub { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("unsubscribeAutomation")]
        public object UnsubscribeAutomation { get; set; }

        [JsonProperty("automation")]
        public object Automation { get; set; }

        [JsonProperty("links")]
        public ContactEmailListLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<EmailList> GetEmailList(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.List.ToString();
            var result = Connection.ExecuteGetRequest<EmailList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Form> GetForm(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Form.ToString();
            var result = Connection.ExecuteGetRequest<Form>(linkedUrl);
            return result;
        }

        //TODO: HOLD - Needs more JSON examples for AutosyncLog
        public ActiveCampaignResult<object> GetAutosyncLog(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AutosyncLog.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Campaign> GetCampaign(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Campaign.ToString();
            var result = Connection.ExecuteGetRequest<Campaign>(linkedUrl);
            return result;
        }

        //TODO: HOLD - Needs more JSON examples for UnsubscribeAutomation
        public ActiveCampaignResult<object> GetUnsubscribeAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.UnsubscribeAutomation.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Message> GetMessage(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Message.ToString();
            var result = Connection.ExecuteGetRequest<Message>(linkedUrl);
            return result;
        }
        
        #endregion
        
    }

    public class ContactEmailListLinks
    {
        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("list")]
        public Uri List { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("form")]
        public Uri Form { get; set; }

        [JsonProperty("autosyncLog")]
        public Uri AutosyncLog { get; set; }

        [JsonProperty("campaign")]
        public Uri Campaign { get; set; }

        [JsonProperty("unsubscribeAutomation")]
        public Uri UnsubscribeAutomation { get; set; }

        [JsonProperty("message")]
        public Uri Message { get; set; }
    }
}
