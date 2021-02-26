namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    public class Campaign
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("automation")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Automation { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("segmentid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SegmentId { get; set; }

        [JsonProperty("bounceid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BounceId { get; set; }

        [JsonProperty("realcid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long RealcId { get; set; }

        [JsonProperty("sendid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SendId { get; set; }

        [JsonProperty("threadid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ThreadId { get; set; }

        [JsonProperty("seriesid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SeriesId { get; set; }

        [JsonProperty("formid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long FormId { get; set; }

        [JsonProperty("basetemplateid")]
        public string BaseTemplateId { get; set; }

        [JsonProperty("basemessageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BaseMessageId { get; set; }

        [JsonProperty("addressid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long AddressId { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset? MDate { get; set; }

        [JsonProperty("sdate")]
        public DateTimeOffset? SDate { get; set; }

        [JsonProperty("ldate")]
        public DateTimeOffset? LDate { get; set; }

        [JsonProperty("send_amt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SendAmt { get; set; }

        [JsonProperty("total_amt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TotalAmt { get; set; }

        [JsonProperty("opens")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Opens { get; set; }

        [JsonProperty("uniqueopens")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueOpens { get; set; }

        [JsonProperty("linkclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LinkClicks { get; set; }

        [JsonProperty("uniquelinkclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueLinkClicks { get; set; }

        [JsonProperty("subscriberclicks")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SubscriberClicks { get; set; }

        [JsonProperty("forwards")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Forwards { get; set; }

        [JsonProperty("uniqueforwards")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueForwards { get; set; }

        [JsonProperty("hardbounces")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long HardBounces { get; set; }

        [JsonProperty("softbounces")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SoftBounces { get; set; }

        [JsonProperty("unsubscribes")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Unsubscribes { get; set; }

        [JsonProperty("unsubreasons")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UnsubReasons { get; set; }

        [JsonProperty("updates")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Updates { get; set; }

        [JsonProperty("socialshares")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SocialShares { get; set; }

        [JsonProperty("replies")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Replies { get; set; }

        [JsonProperty("uniquereplies")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UniqueReplies { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("public")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Public { get; set; }

        [JsonProperty("mail_transfer")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MailTransfer { get; set; }

        [JsonProperty("mail_send")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MailSend { get; set; }

        [JsonProperty("mail_cleanup")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MailCleanup { get; set; }

        [JsonProperty("mailer_log_file")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MailerLogFile { get; set; }

        [JsonProperty("tracklinks")]
        public TrackLinks TrackLinks { get; set; }

        [JsonProperty("tracklinksanalytics")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TrackLinksAnalytics { get; set; }

        [JsonProperty("trackreads")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TrackReads { get; set; }

        [JsonProperty("trackreadsanalytics")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TrackReadsAnalytics { get; set; }

        [JsonProperty("analytics_campaign_name")]
        public string AnalyticsCampaignName { get; set; }

        [JsonProperty("tweet")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Tweet { get; set; }

        [JsonProperty("facebook")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Facebook { get; set; }

        [JsonProperty("survey")]
        public string Survey { get; set; }

        [JsonProperty("embed_images")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long EmbedImages { get; set; }

        [JsonProperty("htmlunsub")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long HtmlUnsub { get; set; }

        [JsonProperty("textunsub")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TextUnsub { get; set; }

        [JsonProperty("htmlunsubdata")]
        public string HtmlUnsubData { get; set; }

        [JsonProperty("textunsubdata")]
        public string TextUnsubData { get; set; }

        [JsonProperty("recurring")]
        public ActiverssInterval Recurring { get; set; }

        [JsonProperty("willrecur")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long WillRecur { get; set; }

        [JsonProperty("split_type")]
        public SplitType SplitType { get; set; }

        [JsonProperty("split_content")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SplitContent { get; set; }

        [JsonProperty("split_offset")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SplitOffset { get; set; }

        [JsonProperty("split_offset_type")]
        public OffsetType SplitOffsetType { get; set; }

        [JsonProperty("split_winner_messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SplitWinnerMessageId { get; set; }

        [JsonProperty("split_winner_awaiting")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SplitWinnerAwaiting { get; set; }

        [JsonProperty("responder_offset")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ResponderOffset { get; set; }

        [JsonProperty("responder_type")]
        public ResponderType ResponderType { get; set; }

        [JsonProperty("responder_existing")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ResponderExisting { get; set; }

        [JsonProperty("reminder_field")]
        public ReminderField ReminderField { get; set; }

        [JsonProperty("reminder_format")]
        public ReminderFormat ReminderFormat { get; set; }

        [JsonProperty("reminder_type")]
        public ReminderType ReminderType { get; set; }

        [JsonProperty("reminder_offset")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ReminderOffset { get; set; }

        [JsonProperty("reminder_offset_type")]
        public OffsetType ReminderOffsetType { get; set; }

        [JsonProperty("reminder_offset_sign")]
        public ReminderOffsetSign ReminderOffsetSign { get; set; }

        [JsonProperty("reminder_last_cron_run")]
        public string ReminderLastCronRun { get; set; }

        [JsonProperty("activerss_interval")]
        public ActiverssInterval ActiverssInterval { get; set; }

        [JsonProperty("activerss_url")]
        public string ActiverssUrl { get; set; }

        [JsonProperty("activerss_items")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ActiverssItems { get; set; }

        [JsonProperty("ip4")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4 { get; set; }

        [JsonProperty("laststep")]
        public LastStep LastStep { get; set; }

        [JsonProperty("managetext")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ManageText { get; set; }

        [JsonProperty("schedule")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Schedule { get; set; }

        [JsonProperty("scheduleddate")]
        public object ScheduledDate { get; set; }

        [JsonProperty("waitpreview")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long WaitPreview { get; set; }

        [JsonProperty("deletestamp")]
        public object DeleteStamp { get; set; }

        [JsonProperty("replysys")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ReplySys { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? UpdatedBy { get; set; }

        [JsonProperty("ip")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip { get; set; }

        [JsonProperty("series_send_lock_time")]
        public object SeriesSendLockTime { get; set; }

        [JsonProperty("segmentname")]
        public string SegmentName { get; set; }

        [JsonProperty("has_predictive_content")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long HasPredictiveContent { get; set; }

        [JsonProperty("screenshot")]
        public string Screenshot { get; set; }

        [JsonProperty("links")]
        public CampaignLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Automation> GetAutomation(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Automation.ToString();
            var result = Connection.ExecuteGetRequest<Automation>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<CampaignMessage> GetCampaignMessage(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CampaignMessage.ToString();
            var result = Connection.ExecuteGetRequest<CampaignMessage>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<CampaignMessagesList> GetCampaignMessages(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CampaignMessages.ToString();
            var result = Connection.ExecuteGetRequest<CampaignMessagesList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<HyperLinksList> GetCampaignLinks(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Links.ToString();
            var result = Connection.ExecuteGetRequest<HyperLinksList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AggregateRevenuesList> GetAggregateRevenues(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AggregateRevenues.ToString();
            var result = Connection.ExecuteGetRequest<AggregateRevenuesList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<SegmentsList> GetSegment(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Segment.ToString();
            var result = Connection.ExecuteGetRequest<SegmentsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<CampaignEmailListsList> GetCampaignLists(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CampaignLists.ToString();
            var result = Connection.ExecuteGetRequest<CampaignEmailListsList>(linkedUrl);
            return result;
        }
       
        #endregion

    }

    public class CampaignLinks
    {
        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("automation")]
        public Uri Automation { get; set; }

        [JsonProperty("campaignMessage")]
        public Uri CampaignMessage { get; set; }

        [JsonProperty("campaignMessages")]
        public Uri CampaignMessages { get; set; }

        [JsonProperty("links")]
        public Uri Links { get; set; }

        [JsonProperty("aggregateRevenues")]
        public Uri AggregateRevenues { get; set; }

        [JsonProperty("segment")]
        public Uri Segment { get; set; }

        [JsonProperty("campaignLists")]
        public Uri CampaignLists { get; set; }
    }

}
