namespace Dragonfly.ActiveCampaign.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

    //Custom Account Fields https://developers.activecampaign.com/reference#custom-account-fields-1

    public class AccountCustomFieldRequest : ActiveCampaignRequest<AccountCustomFieldMetaList>
    {
        private string listEndPoint = "accountCustomFieldMeta?limit=100";
        private string singleEndPoint = "accountCustomFieldMeta";

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
        public List<AccountCustomFieldMetaList.LinkedData> IncludeExtraData { get; set; }

        public AccountCustomFieldRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<AccountCustomFieldMetaList.LinkedData>();
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

            //Add filter fields
            //var jsonName = PropertyHelper<CustomAccountFieldRequest>.GetJsonName(x => x.Ids);
            //Fields.Add(jsonName, Id.ToString());

            //Need to use route format
            var reqUrl = $"{singleEndPoint}/{Id}";

            //get result
            var result = this.Connection.ExecuteGetRequest(reqUrl, this);
            this.Result = result;
        }
        
        //TODO: Add Pagination support?
        public void GetList()
        {
            //clear filter fields - whatever properties have been set on this request will be used for the query
            Reset();

            //get result
            var result = this.Connection.ExecuteGetRequest(listEndPoint, this);
            this.Result = result;
        }

     
        #endregion

        #region Overrides of ActiveCampaignRequest<T>

        internal override IEnumerable<string> LinkedDataParams()
        {
            return AccountCustomFieldMetaList.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion

    }
}