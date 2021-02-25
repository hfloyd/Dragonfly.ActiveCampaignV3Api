namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using Dragonfly.ActiveCampaign.Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Deal
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("account")]
        public long Account { get; set; }

        [JsonProperty("customerAccount")]
        public long CustomerAccount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("percent")]
        public object Percent { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("organization")]
        public long Organization { get; set; }

        [JsonProperty("contact")]
        public long Contact { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("owner")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Owner { get; set; }

        [JsonProperty("stage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Stage { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("nextdate")]
        public object NextDate { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("winProbability")]
        public object WinProbability { get; set; }

        [JsonProperty("winProbabilityMdate")]
        public object WinProbabilityMDate { get; set; }

        [JsonProperty("fields")]
        public List<DealCustomField> DealFields { get; set; }

        [JsonProperty("links")]
        public DealLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<DealActivitiesList> GetDealActivities(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealActivities.ToString();
            var result = Connection.ExecuteGetRequest<DealActivitiesList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Contact> GetContact(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Contact.ToString();
            var result = Connection.ExecuteGetRequest<Contact>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ContactDealsList> GetContactDeals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactDeals.ToString();
            var result = Connection.ExecuteGetRequest<ContactDealsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        //TODO: HOLD - Needs more JSON examples for Task
        public ActiveCampaignResult<object> GetNextTask(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.NextTask.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<NotesList> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<NotesList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Account> GetAccount(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Account.ToString();
            var result = Connection.ExecuteGetRequest<Account>(linkedUrl);
            return result;
        }

        //TODO: HOLD - Needs more JSON examples for CustomerAccount
        public ActiveCampaignResult<object> GetCustomerAccount(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.CustomerAccount.ToString();
            var result = Connection.ExecuteGetRequest<object>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Organization> GetOrganization(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Organization.ToString();
            var result = Connection.ExecuteGetRequest<Organization>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Owner> GetOwner(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Owner.ToString();
            var result = Connection.ExecuteGetRequest<Owner>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ScoreValuesList> GetScoreValues(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ScoreValues.ToString();
            var result = Connection.ExecuteGetRequest<ScoreValuesList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealStage> GetStage(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Stage.ToString();
            var result = Connection.ExecuteGetRequest<DealStage>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<TasksList> GetTasks(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Tasks.ToString();
            var result = Connection.ExecuteGetRequest<TasksList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealCustomFieldDataList> GetDealCustomFieldData(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealCustomFieldData.ToString();
            var result = Connection.ExecuteGetRequest<DealCustomFieldDataList>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params to DealRequest?
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

    public class DealLinks
    {
        [JsonProperty("dealActivities")]
        public string DealActivities { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("contactDeals")]
        public string ContactDeals { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("nextTask")]
        public string NextTask { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("customerAccount")]
        public string CustomerAccount { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("scoreValues")]
        public string ScoreValues { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("tasks")]
        public string Tasks { get; set; }

        [JsonProperty("dealCustomFieldData")]
        public string DealCustomFieldData { get; set; }
    }

}
