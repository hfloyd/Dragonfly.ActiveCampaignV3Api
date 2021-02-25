namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    public class Contact
    {
        private Dictionary<string, JToken> _additionalData;

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("orgid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OrgId { get; set; }

        [JsonProperty("orgname")]
        public string OrganizationName { get; set; }

        [JsonProperty("organization")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OrganizationId { get; set; }

        [JsonProperty("segmentio_id")]
        public string SegmentioId { get; set; }

        [JsonProperty("bounced_hard")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BouncedHard { get; set; }

        [JsonProperty("bounced_soft")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long BouncedSoft { get; set; }

        [JsonProperty("bounced_date")]
        public string BouncedDate { get; set; }

        [JsonProperty("ip")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip { get; set; }

        [JsonProperty("ua")]
        public string Ua { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("socialdata_lastcheck")]
        public string SocialDataLastCheck { get; set; }

        [JsonProperty("email_local")]
        public string EmailLocal { get; set; }

        [JsonProperty("email_domain")]
        public string EmailDomain { get; set; }

        [JsonProperty("sentcnt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long SentCount { get; set; }

        [JsonProperty("rating_tstamp")]
        [JsonConverter(typeof(DtOffsetConverter))]
        public DateTimeOffset RatingTimestamp { get; set; }

        [JsonProperty("gravatar")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Gravatar { get; set; }

        [JsonProperty("deleted")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Deleted { get; set; }

        [JsonProperty("anonymized")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Anonymized { get; set; }

        [JsonProperty("email_empty")]
        public bool EmailEmpty { get; set; }

        [JsonProperty("accountContacts")]
        public List<object> AccountContacts { get; set; }

        [JsonProperty("scoreValues")]
        //[JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> ScoreValues { get; set; }

        [JsonProperty("adate")]
        public DateTimeOffset ADate { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("edate")]
        public DateTimeOffset EDate { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_utc_timestamp")]
        public DateTimeOffset CreatedUtcTimestamp { get; set; }

        [JsonProperty("updated_utc_timestamp")]
        public DateTimeOffset UpdatedUtcTimestamp { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UpdatedBy { get; set; }

        [JsonProperty("links")]
        public ContactLinks Links { get; set; }

        public Contact()
        {
            _additionalData = new Dictionary<string, JToken>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            // For items not deserialized to any property
            // and so it is added to the extension data dictionary
            //string samAccountName = (string)_additionalData["SAMAccountName"];

            //Domain = samAccountName.Split('\\')[0];
            //UserName = samAccountName.Split('\\')[1];
        }

        #region Linked Data Methods
        public ActiveCampaignResult<BounceLogsList> GetBounceLogs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.BounceLogs.ToString();
            var result = Connection.ExecuteGetRequest<BounceLogsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactAutomationsList> GetContactAutomations(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactAutomations.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomationsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactData> GetContactData(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactData.ToString();
            var result = Connection.ExecuteGetRequest<ContactData>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactGoalsList> GetContactGoals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactGoals.ToString();
            var result = Connection.ExecuteGetRequest<ContactGoalsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactEmailListsList> GetContactLists(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactLists.ToString();
            var result = Connection.ExecuteGetRequest<ContactEmailListsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactLogsList> GetContactLogs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactLogs.ToString();
            var result = Connection.ExecuteGetRequest<ContactLogsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactTagsList> GetContactTags(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactTags.ToString();
            var result = Connection.ExecuteGetRequest<ContactTagsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactDealsList> GetContactDeals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactDeals.ToString();
            var result = Connection.ExecuteGetRequest<ContactDealsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<DealsList> GetDeals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Deals.ToString();
            var result = Connection.ExecuteGetRequest<DealsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactFieldValues> GetContactFieldValues(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.FieldValues.ToString();
            var result = Connection.ExecuteGetRequest<ContactFieldValues>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactGeoIps> GetGeoIps(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.GeoIps.ToString();
            var result = Connection.ExecuteGetRequest<ContactGeoIps>(linkedUrl);
            return result;
        }
   
        public ActiveCampaignResult<NotesList> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<NotesList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactOrganization> GetOrganization(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Organization.ToString();
            var result = Connection.ExecuteGetRequest<ContactOrganization>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactPlusAppend> GetPlusAppend(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.PlusAppend.ToString();
            var result = Connection.ExecuteGetRequest<ContactPlusAppend>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<TrackingLogsList> GetTrackingLogs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.TrackingLogs.ToString();
            var result = Connection.ExecuteGetRequest<TrackingLogsList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ScoreValuesList> GetScoreValues(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ScoreValues.ToString();
            var result = Connection.ExecuteGetRequest<ScoreValuesList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<ContactAutomationEntryCounts> GetAutomationEntryCounts(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.AutomationEntryCounts.ToString();
            var result = Connection.ExecuteGetRequest<ContactAutomationEntryCounts>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params

        public enum LinkedData
        {
            BounceLogs,
            ContactAutomations,
            ContactData,
            ContactGoals,
            ContactLists,
            ContactLogs,
            ContactTags,
            ContactDeals,
            Deals,
            FieldValues,
            GeoIps,
            Notes,
            Organization,
            PlusAppend,
            TrackingLogs,
            ScoreValues
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<Contact.LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.BounceLogs:
                        list.Add("bounceLogs");
                        break;
                    case LinkedData.ContactAutomations:
                        list.Add("contactAutomations.automation");
                        break;
                    case LinkedData.ContactData:
                        list.Add("contactData");
                        break;
                    case LinkedData.ContactGoals:
                        list.Add("contactGoals");
                        break;
                    case LinkedData.ContactLists:
                        list.Add("contactLists.list");
                        break;
                    case LinkedData.ContactLogs:
                        list.Add("contactLogs");
                        break;
                    case LinkedData.ContactTags:
                        list.Add("contactTags.tag");
                        break;
                    case LinkedData.ContactDeals:
                        list.Add("contactDeals");
                        break;
                    case LinkedData.Deals:
                        list.Add("deals");
                        break;
                    case LinkedData.FieldValues:
                        list.Add("fieldValues.field");
                        break;
                    case LinkedData.GeoIps:
                        list.Add("geoIps.geoAddress");
                        break;
                    case LinkedData.Notes:
                        list.Add("notes");
                        break;
                    case LinkedData.Organization:
                        list.Add("organization");
                        break;
                    case LinkedData.PlusAppend:
                        list.Add("plusAppend");
                        break;
                    case LinkedData.TrackingLogs:
                        list.Add("trackingLogs");
                        break;
                    case LinkedData.ScoreValues:
                        list.Add("scoreValues.score");
                        break;
                    //case LinkedData.AutomationEntryCounts:
                    //    list.Add("automationEntryCounts");
                    //    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return list;
        }
        
        #endregion
    }

    public class ContactLinks
    {
        [JsonProperty("bounceLogs")]
        public Uri BounceLogs { get; set; }

        [JsonProperty("contactAutomations")]
        public Uri ContactAutomations { get; set; }

        [JsonProperty("contactData")]
        public Uri ContactData { get; set; }

        [JsonProperty("contactGoals")]
        public Uri ContactGoals { get; set; }

        [JsonProperty("contactLists")]
        public Uri ContactLists { get; set; }

        [JsonProperty("contactLogs")]
        public Uri ContactLogs { get; set; }

        [JsonProperty("contactTags")]
        public Uri ContactTags { get; set; }

        [JsonProperty("contactDeals")]
        public Uri ContactDeals { get; set; }

        [JsonProperty("deals")]
        public Uri Deals { get; set; }

        [JsonProperty("fieldValues")]
        public Uri FieldValues { get; set; }

        [JsonProperty("geoIps")]
        public Uri GeoIps { get; set; }

        [JsonProperty("notes")]
        public Uri Notes { get; set; }

        [JsonProperty("organization")]
        public Uri Organization { get; set; }

        [JsonProperty("plusAppend")]
        public Uri PlusAppend { get; set; }

        [JsonProperty("trackingLogs")]
        public Uri TrackingLogs { get; set; }

        [JsonProperty("scoreValues")]
        public Uri ScoreValues { get; set; }

        [JsonProperty("automationEntryCounts")]
        public Uri AutomationEntryCounts { get; set; }
    }

}
