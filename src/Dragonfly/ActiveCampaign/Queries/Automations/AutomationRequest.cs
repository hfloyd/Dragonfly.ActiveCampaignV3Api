namespace Dragonfly.ActiveCampaign.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

   // https://developers.activecampaign.com/reference#list-all-automations

    public class AutomationRequest : ActiveCampaignRequest<AutomationsList>
    {
        private string listEndPoint = "automations";
        private string singleEndPoint = "automations";

        #region Filtering Properties
        
        ///// <summary>
        ///// Filter by Multiple Ids
        ///// </summary>
        //[JsonProperty("ids")]
        //public IEnumerable<long> Ids { get; set; }

        #endregion

        /// <summary>
        /// Sideload additional LinkedData in the result
        /// </summary>
        public List<AutomationsList.LinkedData> IncludeExtraData { get; set; }

        public AutomationRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<AutomationsList.LinkedData>();
        }

        #region Filtering

        /// <summary>
        /// Lookup by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void GetSingle(int Id)
        {
            Reset();

            //Need to use route format
            var reqUrl = $"{singleEndPoint}/{Id}";

            //get result
            var result = this.Connection.ExecuteGetRequest(reqUrl, this);
            this.Result = result;
        }

        /// <summary>
        ///// Lookup by string value
        ///// </summary>
        ///// <param name="SomeProp">Some unique string property</param>
        ///// <returns>Single Contact or NULL</returns>
        //public void GetSingle(string SomeProp)
        //{
        //    Reset();

        //    //Add filter fields
        //    var jsonName = PropertyHelper<AutomationRequest>.GetJsonName(x => x.SomeProp);
        //    Fields.Add(jsonName, SomeProp);

        //    //get result
        //    var result = this.Connection.ExecuteGetRequest(singleEndPoint, this);
        //    this.Result = result;
        //}

        //TODO: Add Pagination support for AutomationsList?
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
            return AutomationsList.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion

    }
}