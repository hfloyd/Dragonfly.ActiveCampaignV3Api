namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for AccountsList
    public class AccountsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accounts")]
        public List<Account> Accounts { get; set; }

        #region Sideloading Params

        //TODO: Add Sideloading Params
        public enum LinkedData
        {
            XX,

        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.XX:
                        list.Add("xx");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return list;
        }

        #endregion
    }

}