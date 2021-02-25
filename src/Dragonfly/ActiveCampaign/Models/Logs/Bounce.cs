namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Bounce
    {
        [JsonProperty("result")]
        public BounceResult Result { get; set; }
    }

    public class BounceResult
    {

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Userid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("host")]
        public object Host { get; set; }

        [JsonProperty("port")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Port { get; set; }

        [JsonProperty("user")]
        public object User { get; set; }

        [JsonProperty("pass")]
        public object Pass { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("limit_hard")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitHard { get; set; }

        [JsonProperty("limit_soft")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitSoft { get; set; }

        [JsonProperty("emails_per_batch")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long EmailsPerBatch { get; set; }

        [JsonProperty("links")]
        public List<object> Links { get; set; }

    }
}