namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class FieldOptions
    {
        [JsonProperty("fieldOptions")]
        public List<FieldOption> Data { get; set; }
    }

    public class FieldOption
    {
        [JsonProperty("field")]
        public long FieldId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }
        
        [JsonProperty("links")]
        public FieldOptionLinks Links { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<Field> GetField(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Field.ToString();
            var result = Connection.ExecuteGetRequest<Field>(linkedUrl);
            return result;
        }

        #endregion
    }

    public  class FieldOptionLinks
    {
        [JsonProperty("field")]
        public Uri Field { get; set; }
    }
}