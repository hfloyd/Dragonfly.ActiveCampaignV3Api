namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ContactDeal
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Contact { get; set; }

        [JsonProperty("organization")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Organization { get; set; }

        [JsonProperty("owner")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Owner { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("stage")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Stage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("percent")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Percent { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("nextdate")]
        public object NextDate { get; set; }

        [JsonProperty("nexttaskid")]
        public object NextTaskId { get; set; }

        [JsonProperty("value")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("winProbability")]
        public long WinProbability { get; set; }

        [JsonProperty("winProbabilityMdate")]
        public DateTimeOffset WinProbabilityMDate { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Status { get; set; }

        [JsonProperty("activitycount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ActivityCount { get; set; }

        [JsonProperty("nextdealid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long NextDealId { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("account")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Account { get; set; }

        [JsonProperty("customerAccount")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CustomerAccount { get; set; }

        [JsonProperty("edate")]
        public DateTimeOffset EDate { get; set; }

        [JsonProperty("links")]
        public ContactDealLinks Links { get; set; }

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
        public ActiveCampaignResult<ContactDeal> GetContactDeals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.ContactDeals.ToString();
            var result = Connection.ExecuteGetRequest<ContactDeal>(linkedUrl);
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
        public ActiveCampaignResult<Note> GetNotes(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Notes.ToString();
            var result = Connection.ExecuteGetRequest<Note>(linkedUrl);
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

        //TODO: HOLD - Add Sideloading Params for ContactDealRequest?
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

    public  class ContactDealLinks
    {
        [JsonProperty("dealActivities")]
        public Uri DealActivities { get; set; }

        [JsonProperty("contact")]
        public Uri Contact { get; set; }

        [JsonProperty("contactDeals")]
        public Uri ContactDeals { get; set; }

        [JsonProperty("group")]
        public Uri Group { get; set; }

        [JsonProperty("nextTask")]
        public Uri NextTask { get; set; }

        [JsonProperty("notes")]
        public Uri Notes { get; set; }

        [JsonProperty("account")]
        public Uri Account { get; set; }

        [JsonProperty("customerAccount")]
        public Uri CustomerAccount { get; set; }

        [JsonProperty("organization")]
        public Uri Organization { get; set; }

        [JsonProperty("owner")]
        public Uri Owner { get; set; }

        [JsonProperty("scoreValues")]
        public Uri ScoreValues { get; set; }

        [JsonProperty("stage")]
        public Uri Stage { get; set; }

        [JsonProperty("tasks")]
        public Uri Tasks { get; set; }

        [JsonProperty("dealCustomFieldData")]
        public Uri DealCustomFieldData { get; set; }
    }
}
