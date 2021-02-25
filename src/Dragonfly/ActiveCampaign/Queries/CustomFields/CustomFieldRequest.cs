namespace Dragonfly.ActiveCampaign.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Newtonsoft.Json;

    //  https://developers.activecampaign.com/reference?_ga=2.79471828.1564152.1611946105-1183065105.1584984488#retrieve-fields-1
    public class CustomFieldRequest : ActiveCampaignRequest<FieldsList>
    {
        private string listEndPoint = "fields/?limit=100";
        private string singleEndPoint = "fields";

        #region Filtering Properties

        /// <summary>
        /// Filter by Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        #endregion

        /// <summary>
        /// Sideload additional LinkedData in the result
        /// </summary>
        public List<Field.LinkedData> IncludeExtraData { get; set; }

        public CustomFieldRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<Field.LinkedData>();

        }

        #region Filtering

        /// <summary>
        /// Lookup a Custom Field by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void GetSingle(int Id)
        {
            Reset();

            //Add filter fields
            var jsonName = PropertyHelper<CustomFieldRequest>.GetJsonName(x => x.Id);
            Fields.Add(jsonName, Id.ToString());

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
            return Field.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion
    }
}
