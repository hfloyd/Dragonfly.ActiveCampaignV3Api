namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ContactGeoIps
    {
        [JsonProperty("geoIps")]
        public List<ContactGeoIp> Data { get; set; }
    }

    public partial class ContactGeoIp
    {
        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("messageid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MessageId { get; set; }

        [JsonProperty("geoaddrid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoaddrId { get; set; }

        [JsonProperty("ip4")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Ip4 { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("links")]
        public ContactGeoIpLinks Links { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("geoAddress")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoAddress { get; set; }
    }

    public class ContactGeoIpLinks
    {
        [JsonProperty("geoAddress")]
        public Uri GeoAddress { get; set; }
    }
}