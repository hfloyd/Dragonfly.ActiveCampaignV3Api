namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class AddressLists
    {
        [JsonProperty("addressLists")]
        public List<Address> Data { get; set; }
    }
}
