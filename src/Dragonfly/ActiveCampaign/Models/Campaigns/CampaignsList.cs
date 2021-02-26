namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    using Newtonsoft.Json;

    /// <summary>
    /// Returned from 'CampaignRequest'
    /// </summary>

    public class CampaignsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("campaign")]
        public Campaign Campaign { get; set; }

        [JsonProperty("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonProperty("users")]
        public List<User> Users { get; set; }

        //TODO: HOLD - Needs more JSON examples for XX
        [JsonProperty("automations")]
        public List<Automation> Automations { get; set; }

        [JsonProperty("campaignMessages")]
        public List<CampaignMessage> CampaignMessages { get; set; }

        [JsonProperty("links")]
        public List<LinkElement> Links { get; set; }

        [JsonProperty("aggregateRevenues")]
        public List<object> AggregateRevenues { get; set; }

        [JsonProperty("campaignLists")]
        public List<CampaignList> CampaignLists { get; set; }


        #region Sideloading Params

        public enum LinkedData
        {
            User,
            Automation,
            CampaignMessage,
            CampaignMessages,
            Hyperlinks,
            AggregateRevenues,
            Segment,
            CampaignLists
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.User:
                        list.Add("user");
                        break;
                    case LinkedData.Automation:
                        list.Add("automation");
                        break;
                    case LinkedData.CampaignMessage:
                        list.Add("campaignMessage");
                        break;
                    case LinkedData.CampaignMessages:
                        list.Add("campaignMessages"); 
                        break;
                    case LinkedData.Hyperlinks:
                        list.Add("links"); 
                        break;
                    case LinkedData.AggregateRevenues:
                        list.Add("aggregateRevenues"); 
                        break;
                    case LinkedData.Segment:
                        list.Add("segment"); 
                        break;
                    case LinkedData.CampaignLists:
                        list.Add("campaignLists"); 
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
