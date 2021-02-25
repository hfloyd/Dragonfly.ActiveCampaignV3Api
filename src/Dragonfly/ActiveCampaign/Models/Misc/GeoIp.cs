namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class GeoIp
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("geoAddress")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoAddress { get; set; }
        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Contact { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MessageId { get; set; }

        [JsonProperty("geoaddrid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoAddressId { get; set; }

        [JsonProperty("ip4")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4 { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("links")]
        public GeoIpLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<GeoAddressesList> GetGeoAddress(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.GeoAddress.ToString();
            var result = Connection.ExecuteGetRequest<GeoAddressesList>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class GeoIpLinks
    {
        [JsonProperty("geoAddress")]
        public Uri GeoAddress { get; set; }
    }
}
