namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class GroupLimit
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("groupid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Groupid { get; set; }

        [JsonProperty("limitMail")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitMail { get; set; }

        [JsonProperty("limitMailType")]
        public string LimitMailType { get; set; }

        [JsonProperty("limitContact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitContact { get; set; }

        [JsonProperty("limitList")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitList { get; set; }

        [JsonProperty("limitCampaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitCampaign { get; set; }

        [JsonProperty("limitCampaignType")]
        public string LimitCampaignType { get; set; }

        [JsonProperty("limitAttachment")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitAttachment { get; set; }

        [JsonProperty("limitUser")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long LimitUser { get; set; }

        [JsonProperty("abuseRatio")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long AbuseRatio { get; set; }

        [JsonProperty("forceSenderInfo")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ForceSenderInfo { get; set; }

        [JsonProperty("links")]
        public GroupLimitLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        #endregion
    }

    public class GroupLimitLinks
    {
        [JsonProperty("group")]
        public Uri Group { get; set; }
    }
}
