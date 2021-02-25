namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public class Group
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("descript")]
        public string Descript { get; set; }

        [JsonProperty("unsubscribelink")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Unsubscribelink { get; set; }

        [JsonProperty("optinconfirm")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Optinconfirm { get; set; }

        [JsonProperty("p_admin")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PAdmin { get; set; }

        [JsonProperty("pgListAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListAdd { get; set; }

        [JsonProperty("pgListEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListEdit { get; set; }

        [JsonProperty("pgListDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListDelete { get; set; }

        [JsonProperty("pgListHeaders")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListHeaders { get; set; }

        [JsonProperty("pgListEmailaccount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListEmailaccount { get; set; }

        [JsonProperty("pgListBounce")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgListBounce { get; set; }

        [JsonProperty("pgMessageAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgMessageAdd { get; set; }

        [JsonProperty("pgMessageEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgMessageEdit { get; set; }

        [JsonProperty("pgMessageDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgMessageDelete { get; set; }

        [JsonProperty("pgMessageSend")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgMessageSend { get; set; }

        [JsonProperty("pgContactAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactAdd { get; set; }

        [JsonProperty("pgContactEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactEdit { get; set; }

        [JsonProperty("pgContactDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactDelete { get; set; }

        [JsonProperty("pgContactMerge")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactMerge { get; set; }

        [JsonProperty("pgContactImport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactImport { get; set; }

        [JsonProperty("pgContactApprove")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactApprove { get; set; }

        [JsonProperty("pgContactExport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactExport { get; set; }

        [JsonProperty("pgContactSync")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactSync { get; set; }

        [JsonProperty("pgContactFilters")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactFilters { get; set; }

        [JsonProperty("pgContactActions")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactActions { get; set; }

        [JsonProperty("pgContactFields")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactFields { get; set; }

        [JsonProperty("pg_user_add")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgUserAdd { get; set; }

        [JsonProperty("pg_user_edit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgUserEdit { get; set; }

        [JsonProperty("pg_user_delete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgUserDelete { get; set; }

        [JsonProperty("pgGroupAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgGroupAdd { get; set; }

        [JsonProperty("pgGroupEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgGroupEdit { get; set; }

        [JsonProperty("pgGroupDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgGroupDelete { get; set; }

        [JsonProperty("pgTemplateAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgTemplateAdd { get; set; }

        [JsonProperty("pgTemplateEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgTemplateEdit { get; set; }

        [JsonProperty("pgTemplateDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgTemplateDelete { get; set; }

        [JsonProperty("pgPersonalizationAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgPersonalizationAdd { get; set; }

        [JsonProperty("pgPersonalizationEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgPersonalizationEdit { get; set; }

        [JsonProperty("pgPersonalizationDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgPersonalizationDelete { get; set; }

        [JsonProperty("pgAutomationManage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAutomationManage { get; set; }

        [JsonProperty("pgFormEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgFormEdit { get; set; }

        [JsonProperty("pgReportsCampaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgReportsCampaign { get; set; }

        [JsonProperty("pgReportsList")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgReportsList { get; set; }

        [JsonProperty("pgReportsUser")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgReportsUser { get; set; }

        [JsonProperty("pgReportsTrend")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgReportsTrend { get; set; }

        [JsonProperty("pgReportsDeal")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgReportsDeal { get; set; }

        [JsonProperty("pgStartupReports")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgStartupReports { get; set; }

        [JsonProperty("pgStartupGettingstarted")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgStartupGettingstarted { get; set; }

        [JsonProperty("pgAccountAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountAdd { get; set; }

        [JsonProperty("pgAccountEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountEdit { get; set; }

        [JsonProperty("pgAccountDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountDelete { get; set; }

        [JsonProperty("pgAccountManageCustomField")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountManageCustomField { get; set; }

        [JsonProperty("pgDeal")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDeal { get; set; }

        [JsonProperty("pgDealDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealDelete { get; set; }

        [JsonProperty("pgDealReassign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealReassign { get; set; }

        [JsonProperty("pgDealFields")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealFields { get; set; }

        [JsonProperty("pgDealGroupAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealGroupAdd { get; set; }

        [JsonProperty("pgDealGroupEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealGroupEdit { get; set; }

        [JsonProperty("pgDealGroupDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealGroupDelete { get; set; }

        [JsonProperty("pgSavedResponsesManage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgSavedResponsesManage { get; set; }

        [JsonProperty("sdate")]
        public DateTimeOffset Sdate { get; set; }

        [JsonProperty("reqApproval")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ReqApproval { get; set; }

        [JsonProperty("reqApproval1st")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ReqApproval1St { get; set; }

        [JsonProperty("reqApprovalNotify")]
        public string ReqApprovalNotify { get; set; }

        [JsonProperty("socialdata")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Socialdata { get; set; }

        [JsonProperty("pgMfaAdmin")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgMfaAdmin { get; set; }

        [JsonProperty("pgDealExport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealExport { get; set; }

        [JsonProperty("pgDealManageRoles")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealManageRoles { get; set; }

        [JsonProperty("pgAccountNoteAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountNoteAdd { get; set; }

        [JsonProperty("pgAccountNoteEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountNoteEdit { get; set; }

        [JsonProperty("pgAccountNoteDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountNoteDelete { get; set; }

        [JsonProperty("pgDealNoteAdd")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealNoteAdd { get; set; }

        [JsonProperty("pgDealNoteEdit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealNoteEdit { get; set; }

        [JsonProperty("pgDealNoteDelete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealNoteDelete { get; set; }

        [JsonProperty("pgDealListAll")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealListAll { get; set; }

        [JsonProperty("pgTagManage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgTagManage { get; set; }

        [JsonProperty("pgContactResubscribe")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgContactResubscribe { get; set; }

        [JsonProperty("pgDealImport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgDealImport { get; set; }

        [JsonProperty("pgAccountImport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountImport { get; set; }

        [JsonProperty("pgAccountExport")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgAccountExport { get; set; }

        [JsonProperty("pgLandingPagesAccess")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgLandingPagesAccess { get; set; }

        [JsonProperty("pgWebPersonalizationManage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PgWebPersonalizationManage { get; set; }

        [JsonProperty("links")]
        public GroupLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<UserGroupsList> GetUserGroups(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.UserGroups.ToString();
            var result = Connection.ExecuteGetRequest<UserGroupsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<GroupLimit> GetGroupLimit(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.GroupLimit.ToString();
            var result = Connection.ExecuteGetRequest<GroupLimit>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealGroupGroupsList> GetDealGroupGroups(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealGroupGroups.ToString();
            var result = Connection.ExecuteGetRequest<DealGroupGroupsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ListGroupsList> GetListGroups(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ListGroups.ToString();
            var result = Connection.ExecuteGetRequest<ListGroupsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AddressGroupsList> GetAddressGroups(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AddressGroups.ToString();
            var result = Connection.ExecuteGetRequest<AddressGroupsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<AutomationGroupsList> GetAutomationGroups(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AutomationGroups.ToString();
            var result = Connection.ExecuteGetRequest<AutomationGroupsList>(linkedUrl);
            return result;
        }
  
        #endregion

    }

    public class GroupLinks
    {
        [JsonProperty("userGroups")]
        public Uri UserGroups { get; set; }

        [JsonProperty("groupLimit")]
        public Uri GroupLimit { get; set; }

        [JsonProperty("dealGroupGroups")]
        public Uri DealGroupGroups { get; set; }

        [JsonProperty("listGroups")]
        public Uri ListGroups { get; set; }

        [JsonProperty("addressGroups")]
        public Uri AddressGroups { get; set; }

        [JsonProperty("automationGroups")]
        public Uri AutomationGroups { get; set; }
    }
}
