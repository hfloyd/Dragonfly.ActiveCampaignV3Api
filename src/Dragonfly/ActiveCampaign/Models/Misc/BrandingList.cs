namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    //TODO: HOLD - Needs more JSON examples for BrandingList
    public class BrandingList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        #region Sideloading Params

        //TODO: Add Sideloading Params for BrandingList?
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
