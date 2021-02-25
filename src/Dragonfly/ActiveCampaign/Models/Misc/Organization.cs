namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Organization
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

    }
}
