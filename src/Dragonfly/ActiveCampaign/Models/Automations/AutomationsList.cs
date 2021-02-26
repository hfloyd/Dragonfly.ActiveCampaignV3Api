namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AutomationsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("automation")]
        public Automation Automation { get; set; }

        [JsonProperty("automations")]
        public List<Automation> Automations { get; set; }

        #region Sideloading Params

        public enum LinkedData
        {
            Campaigns,
            ContactGoals,
            ContactAutomations,
            Blocks,
            Goals,
            Sms,
            SiteMessagges,
            Triggers
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.Campaigns:
                        list.Add("campaigns");
                        break;
                    case LinkedData.ContactGoals:
                        list.Add("contactGoals");
                        break;
                    case LinkedData.ContactAutomations:
                        list.Add("contactAutomations");
                        break;
                    case LinkedData.Blocks:
                        list.Add("blocks");
                        break;
                    case LinkedData.Goals:
                        list.Add("goals");
                        break;
                    case LinkedData.Sms:
                        list.Add("sms");
                        break;
                    case LinkedData.SiteMessagges:
                        list.Add("sitemessages");
                        break;
                    case LinkedData.Triggers:
                        list.Add("triggers");
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
