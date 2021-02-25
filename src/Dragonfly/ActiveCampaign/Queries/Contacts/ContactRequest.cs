namespace Dragonfly.ActiveCampaign.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

    //https://developers.activecampaign.com/reference?#list-all-contacts

    public class ContactRequest : ActiveCampaignRequest<ContactsList>
    {
        private string listEndPoint = "contacts";
        private string singleEndPoint = "contacts";

        #region Filtering Properties

        /// <summary>
        /// Filter by Multiple Ids
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Email address of the contact you want to get
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Filter contacts that contain the given value in the email address
        /// </summary>
        [JsonProperty("email_like")]
        public string EmailContains { get; set; }


        /// <summary>
        ///   Exclude from the response the contact with the given ID
        /// </summary>
        [JsonProperty("exclude")]
        public int ExcludeId { get; set; }


        /// <summary>
        ///    Filter contacts associated with the given form
        /// </summary>
        [JsonProperty("formid")]
        public int FormId { get; set; }


        /// <summary>
        ///     Only include contacts with an ID greater than the given ID
        /// </summary>
        [JsonProperty("id_greater")]
        public int IdGreaterThan { get; set; }


        /// <summary>
        ///    Only include contacts with an ID less than the given ID
        /// </summary>
        [JsonProperty("id_less")]
        public int IdLessThan { get; set; }


        /// <summary>
        ///    Filter contacts associated with the given list
        /// </summary>
        [JsonProperty("listid")]
        public string ListId { get; set; }


        /// <summary>
        ///      (Deprecated) Please use Account-Contact end points.Filter contacts associated with the given organization ID
        /// </summary>
        [JsonProperty("organization")]
        public int OrganizationId { get; set; }


        /// <summary>
        ///    Filter contacts that match the given value in the contact names, organization, phone or email
        /// </summary>
        [JsonProperty("search")]
        public string SearchText { get; set; }


        /// <summary>
        ///    Return only contacts that match a list segment (this param initially returns segment information, when it is run a second time it will return contacts that match the segment)
        /// </summary>
        [JsonProperty("segmentid")]
        public int SegmentId { get; set; }


        /// <summary>
        ///      Filter contacts associated with the given automation
        /// </summary>
        [JsonProperty("seriesid")]
        public int SeriesId { get; set; }


        /// <summary>
        ///   See available values
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }


        /// <summary>
        ///      Filter contacts associated with the given tag
        /// </summary>
        [JsonProperty("tagid")]
        public int TagId { get; set; }


        /// <summary>
        ///   Set this to "true" in order to return only contacts that the current user has permissions to see.
        /// </summary>
        [JsonProperty("in_group_lists")]
        public string InGroupLists { get; set; }

        /// <summary>
        /// Sideload additional LinkedData in the result
        /// </summary>
        public List<Contact.LinkedData> IncludeExtraData { get; set; }

        /*
        //TODO: Figure out how to handle formatting these sorts of Query String params (custom Attributes?)
        filters[created_before]
           date
        Filter contacts that were created prior to this date

        filters[created_after]
           date
        Filter contacts that were created after this date

        filters[updated_before]
        date
        Filter contacts that were updated before this date

        filters[updated_after]
        string
        Filter contacts that were updated after this date

        waitid
        int32
        Filter by contacts in the wait queue of an automation block

        orders[cdate]
        string
        Order contacts by creation date

        orders[email]
        string
        Order contacts by email

        orders[first_name]
        string
        Order contacts by first name

        orders[last_name]
        string
        Order contacts by last name

        orders[name]
        string
        Order contacts by full name

        orders[score]
        string
        Order contacts by score

     */
        #endregion

        public ContactRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<Contact.LinkedData>();
        }

        #region Filtering

        /// <summary>
        /// Lookup a Contact by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void GetSingle(int Id)
        {
            Reset();

            //Add filter fields
            var jsonName = PropertyHelper<ContactRequest>.GetJsonName(x => x.Ids);
            Fields.Add(jsonName, Id.ToString());

            //get result
            var result = this.Connection.ExecuteGetRequest(singleEndPoint, this);
            this.Result = result;
        }

        /// <summary>
        /// Lookup a Contact by Email address
        /// </summary>
        /// <param name="Email">Email address of the contact you want to get</param>
        /// <returns>Single Contact or NULL</returns>
        public void GetSingle(string Email)
        {
            Reset();

            //Add filter fields
            var jsonName = PropertyHelper<ContactRequest>.GetJsonName(x => x.Email);
            Fields.Add(jsonName, Email);

            //get result
            var result = this.Connection.ExecuteGetRequest(singleEndPoint, this);
            this.Result = result;
        }

        //TODO: Add Pagination support
        public void GetList()
        {
            //clear filter fields - whatever properties have been set on this request will be used for the query
            Reset();

            //get result
            var result = this.Connection.ExecuteGetRequest(listEndPoint, this);
            this.Result = result;
        }

        //public IEnumerable<Contact> GetAll(int page = 0, string filterField = null, object[] filterValues = null)
        //{
        //    var result = GetContacts("all", page, filterField, filterValues);

        //    if (result != null)
        //    {
        //        return result.Data;
        //    }

        //    return Enumerable.Empty<Contact>();
        //}

        //public IEnumerable<PaginatedContacts.Contact> GetPaginated(int page = 0, int pageSize = 20, int filter = 0, bool isPublic = true)
        //{
        //    var offset = page * pageSize;

        //    var showPublic = isPublic ? 1 : 0;

        //    var request = new PaginatedContactsRequest { Offset = offset, Limit = pageSize, Filter = filter, Public = showPublic };

        //    var result = ExecuteGetRequest<PaginatedContacts>("contact_paginator", request);

        //    if (result != null)
        //    {
        //        return result.Contacts;
        //    }

        //    return Enumerable.Empty<PaginatedContacts.Contact>();
        //}

        #endregion

        #region Overrides of ActiveCampaignRequest<T>

        internal override IEnumerable<string> LinkedDataParams()
        {
            return Contact.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion

    }
}