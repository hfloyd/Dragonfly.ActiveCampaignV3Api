namespace Dragonfly.ActiveCampaign.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

    //https://developers.activecampaign.com/reference?

    public class AddressRequest : ActiveCampaignRequest<AddressesList>
    {
        private string listEndPoint = "addresses";
        private string singleEndPoint = "addresses";

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
        public List<AddressesList.LinkedData> IncludeExtraData { get; set; }

        public AddressRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<AddressesList.LinkedData>();
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
            return AddressesList.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion

    }
}