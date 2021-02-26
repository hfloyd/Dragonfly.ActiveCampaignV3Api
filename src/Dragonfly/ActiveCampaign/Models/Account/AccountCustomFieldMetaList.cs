namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for AccountCustomFieldMetaList
    public class AccountCustomFieldMetaList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("accountCustomFieldMetum")]
        public AccountCustomFieldMetum AccountCustomFieldMetum { get; set; }

        [JsonProperty("accountCustomFieldMeta")]
        public List<AccountCustomFieldMetum> AccountCustomFieldMeta { get; set; }

        #region Sideloading Params

        public enum LinkedData
        {
            AccountCustomFieldData,

        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.AccountCustomFieldData:
                        list.Add("accountCustomFieldData");
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