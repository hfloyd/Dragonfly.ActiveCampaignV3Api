namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AddressesList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        //TODO: HOLD - Needs more JSON examples for AddressGroups
        [JsonProperty("addressGroups")]
        public List<object> AddressGroups { get; set; }

        //TODO: HOLD - Needs more JSON examples for AddressLists
        [JsonProperty("addressLists")]
        public List<object> AddressLists { get; set; }

        [JsonProperty("forms")]
        public List<Form> Forms { get; set; }

        #region Sideloading Params

        public enum LinkedData
        {
            AddressGroup,
            AddressList,
            Forms
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.AddressGroup:
                        list.Add("addressGroup");
                        break;
                    case LinkedData.AddressList:
                        list.Add("addressList");
                        break;
                    case LinkedData.Forms:
                        list.Add("forms");
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
