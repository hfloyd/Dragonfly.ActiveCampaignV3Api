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
        [JsonProperty("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

}
