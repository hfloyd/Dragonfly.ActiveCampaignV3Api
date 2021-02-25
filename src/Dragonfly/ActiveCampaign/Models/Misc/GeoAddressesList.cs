namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GeoAddressesList
    {
        [JsonProperty("geoAddresses")]
        public List<GeoAddress> GeoAddresses { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class GeoAddress
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("ip4")]
        public string Ip4 { get; set; }

        [JsonProperty("country2")]
        public string Country2 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("area")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Area { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }

        [JsonProperty("lon")]
        public string Longitude { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

    }

}