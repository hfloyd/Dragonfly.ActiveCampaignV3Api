namespace Dragonfly.ActiveCampaign.Queries
{
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.Contacts;
    using Newtonsoft.Json;

    //Account Contact Association https://developers.activecampaign.com/reference#account-contacts

    public class AccountContactRequest : ActiveCampaignRequest<AccountContactsList>
    {
        private string listEndPoint = "accountContacts";
        private string singleEndPoint = "accountContacts";

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
        public List<AccountContactsList.LinkedData> IncludeExtraData { get; set; }

        public AccountContactRequest(ActiveCampaignConnection Connection) : base(Connection)
        {
            this.IncludeExtraData = new List<AccountContactsList.LinkedData>();
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
            //var jsonName = PropertyHelper<AccountContactAssociationRequest>.GetJsonName(x => x.Ids);
            //Fields.Add(jsonName, Id.ToString());

            //Need to use route format
            //var reqUrl = $"{singleEndPoint}/{Id}";

            //get result
            var result = this.Connection.ExecuteGetRequest(singleEndPoint, this);
            this.Result = result;
        }

        /// <summary>
        /// Lookup by string value
        /// </summary>
        /// <param name="SomeProp">Some unique string property</param>
        /// <returns>Single Contact or NULL</returns>
        public void GetSingle(string SomeProp)
        {
            Reset();

            //Add filter fields
            var jsonName = PropertyHelper<AccountContactRequest>.GetJsonName(x => x.SomeProp);
            Fields.Add(jsonName, SomeProp);

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

     
        #endregion

        #region Overrides of ActiveCampaignRequest<T>

        internal override IEnumerable<string> LinkedDataParams()
        {
            return AccountContactsList.GetLinkedDataParamsList(this.IncludeExtraData);
        }

        #endregion

    }
}