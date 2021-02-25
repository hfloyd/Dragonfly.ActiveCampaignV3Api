namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    //TODO: HOLD - Needs more JSON examples for SiteMessages
    public class SiteMessageList
    {
        [JsonProperty("siteMessages")]
        public List<object> Data { get; set; }
    }
}
