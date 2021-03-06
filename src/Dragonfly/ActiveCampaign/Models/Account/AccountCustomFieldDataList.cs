﻿namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for AccountCustomFieldDataList
    public class AccountCustomFieldDataList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("accountCustomFieldDatum")]
        public AccountCustomFieldDatum AccountCustomFieldDatum { get; set; }

        [JsonProperty("accountCustomFieldData")]
        public List<AccountCustomFieldDatum> AccountCustomFieldData { get; set; }

        #region Sideloading Params

        public enum LinkedData
        {
            Account,
            AccountCustomFields
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.Account:
                        list.Add("account");
                        break;
                    case LinkedData.AccountCustomFields:
                        list.Add("accountCustomFieldMetum");
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