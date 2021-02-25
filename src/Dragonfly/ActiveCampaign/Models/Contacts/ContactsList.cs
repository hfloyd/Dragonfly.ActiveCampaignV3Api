namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

    /// <summary>
    /// Returned from 'ContactRequest'
    /// </summary>
    public class ContactsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }
        
        [JsonProperty("scoreValues")]
        public List<ScoreValue> ScoreValues { get; set; }

        [JsonProperty("scores")]
        public List<Score> Scores { get; set; }

        [JsonProperty("contactLists")]
        public List<ContactEmailListsList> ContactLists { get; set; }

        [JsonProperty("lists")]
        public List<EmailList> Lists { get; set; }

        [JsonProperty("organization")]
        public List<ContactOrganization> Organization { get; set; }

        //[JsonProperty("automationEntryCounts")]
        //public List<AutomationEntryCount> AutomationEntryCounts { get; set; }

        [JsonProperty("contactAutomations")]
        public List<ContactAutomation> ContactAutomations { get; set; }

        [JsonProperty("bounceLogs")]
        public List<BounceLog> BounceLogs { get; set; }

        [JsonProperty("contactData")]
        public List<ContactDatum> ContactData { get; set; }

        [JsonProperty("contactDeals")]
        public List<ContactDeal> ContactDeals { get; set; }

        [JsonProperty("contactGoals")]
        public List<ContactGoalsList> ContactGoals { get; set; }
        
        [JsonProperty("contactTags")]
        public List<ContactTag> ContactTags { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("deals")]
        public List<Deal> Deals { get; set; }

        [JsonProperty("geoIps")]
        public List<GeoIp> GeoIps { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("organizations")]
        public List<Organization> Organizations { get; set; }

        [JsonProperty("plusAppends")]
        public List<PlusAppend> PlusAppends { get; set; }

        [JsonProperty("contactLogs")]
        public List<ContactLog> ContactLogs { get; set; }

        [JsonProperty("trackingLogs")]
        public List<TrackingLog> TrackingLogs { get; set; }

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

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<ContactsList.LinkedData> DataList)
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


}
