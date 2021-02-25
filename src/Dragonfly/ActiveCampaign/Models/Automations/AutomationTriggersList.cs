namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public partial class AutomationTriggersList
    {
        [JsonProperty("automationTriggers")]
        public List<AutomationTrigger> Data { get; set; }
    }

  
}
