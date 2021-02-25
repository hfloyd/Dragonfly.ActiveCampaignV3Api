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

    }
    

}
