namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Message
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("ed_instanceid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long EdInstanceId { get; set; }

        [JsonProperty("ed_version")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long EdVersion { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("mdate")]
        public DateTimeOffset MDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fromname")]
        public string FromName { get; set; }

        [JsonProperty("fromemail")]
        public string FromEmail { get; set; }

        [JsonProperty("reply2")]
        public string Reply2 { get; set; }

        [JsonProperty("priority")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Priority { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("preheader_text")]
        public string PreheaderText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("htmlfetch")]
        public string HtmlFetch { get; set; }

        [JsonProperty("textfetch")]
        public string TextFetch { get; set; }

        [JsonProperty("hidden")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Hidden { get; set; }

        [JsonProperty("preview_mime")]
        public string PreviewMime { get; set; }

        [JsonProperty("preview_data")]
        public string PreviewData { get; set; }

        [JsonProperty("has_predictive_content")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long HasPredictiveContent { get; set; }

        [JsonProperty("links")]
        public MessageLinks Links { get; set; }


        #region Linked Data Methods

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<HyperLinksList> GetHyperlinks(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Hyperlinks.ToString();
            var result = Connection.ExecuteGetRequest<HyperLinksList>(linkedUrl);
            return result;
        }

        #endregion

    }

    public class MessageLinks
    {
        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("hyperlinks")]
        public Uri Hyperlinks { get; set; }
    }
}
