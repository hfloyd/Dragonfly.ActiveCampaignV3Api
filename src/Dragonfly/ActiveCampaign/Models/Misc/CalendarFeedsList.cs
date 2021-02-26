namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class CalendarFeedsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("calendars")]
        public List<CalendarFeed> Calendars { get; set; }
        
        //TODO: HOLD - Needs more JSON examples for CalendarRels
        [JsonProperty("calendarRels")]
        public List<object> CalendarRels { get; set; }

        //TODO: HOLD - Needs more JSON examples for CalendarUsers
        [JsonProperty("calendarUsers")]
        public List<object> CalendarUsers { get; set; }


        #region Sideloading Params

        public enum LinkedData
        {
            CalendarRelations,
            CalendarUsers
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.CalendarRelations:
                        list.Add("calendarRels");
                        break;
                    case LinkedData.CalendarUsers:
                        list.Add("calendarUsers");
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
