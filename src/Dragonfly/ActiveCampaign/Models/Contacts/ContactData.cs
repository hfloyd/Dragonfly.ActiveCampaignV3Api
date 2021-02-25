namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ContactData
    {
        [JsonProperty("contactDatum")]
        public ContactDatum Data { get; set; }
    }

    public class ContactDatum
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ContactId { get; set; }

        [JsonProperty("tstamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("geoTstamp")]
        public DateTimeOffset GeoTimestamp { get; set; }

        [JsonProperty("geoIp4")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoIp4 { get; set; }

        [JsonProperty("geoCountry2")]
        public string GeoCountry2 { get; set; }

        [JsonProperty("geo_country")]
        public string GeoCountry { get; set; }

        [JsonProperty("geoState")]
        public string GeoState { get; set; }

        [JsonProperty("geoCity")]
        public string GeoCity { get; set; }

        [JsonProperty("geoZip")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoZip { get; set; }

        [JsonProperty("geoArea")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GeoArea { get; set; }

        [JsonProperty("geoLat")]
        public string GeoLatitude { get; set; }

        [JsonProperty("geoLon")]
        public string GeoLongitude { get; set; }

        [JsonProperty("geoTz")]
        public string GeoTimezone { get; set; }

        [JsonProperty("geoTzOffset")]
        public string GeoTimezoneOffset { get; set; }

        [JsonProperty("ga_campaign_source")]
        public string GaCampaignSource { get; set; }

        [JsonProperty("ga_campaign_name")]
        public string GaCampaignName { get; set; }

        [JsonProperty("ga_campaign_medium")]
        public string GaCampaignMedium { get; set; }

        [JsonProperty("ga_campaign_term")]
        public string GaCampaignTerm { get; set; }

        [JsonProperty("ga_campaign_content")]
        public string GaCampaignContent { get; set; }

        [JsonProperty("ga_campaign_customsegment")]
        public string GaCampaignCustomSegment { get; set; }

        [JsonProperty("ga_first_visit")]
        public object GaFirstVisit { get; set; }

        [JsonProperty("ga_times_visited")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long GaTimesVisited { get; set; }

        [JsonProperty("fb_id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long FacebookId { get; set; }

        [JsonProperty("fb_name")]
        public string FacebookName { get; set; }

        [JsonProperty("tw_id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long TwitterId { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

    }

}
