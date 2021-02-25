namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Field
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("descript")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isrequired")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long IsRequired { get; set; }

        [JsonProperty("perstag")]
        public string PersonalizationTag { get; set; }

        [JsonProperty("defval")]
        public string DefaultValue { get; set; }

        [JsonProperty("show_in_list")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ShowInList { get; set; }

        [JsonProperty("rows")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Rows { get; set; }

        [JsonProperty("cols")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Cols { get; set; }

        [JsonProperty("visible")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Visible { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("ordernum")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long OrderNum { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("created_timestamp")]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public DateTimeOffset UpdatedTimestamp { get; set; }

        [JsonProperty("created_by")]
        public object CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public object UpdatedBy { get; set; }

        [JsonProperty("links")]
        public FieldLinks Links { get; set; }


        #region Linked Data Methods

        public ActiveCampaignResult<FieldOptions> GetOptions(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Options.ToString();
            var result = Connection.ExecuteGetRequest<FieldOptions>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<FieldRelations> GetRelations(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Relations.ToString();
            var result = Connection.ExecuteGetRequest<FieldRelations>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params
        public enum LinkedData
        {
            Options,
            Relations
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<Field.LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.Options:
                        list.Add("options");
                        break;
                    case LinkedData.Relations:
                        list.Add("relations");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return list;
        }

        #endregion
    }

    public class FieldLinks
    {
        [JsonProperty("options")]
        public Uri Options { get; set; }

        [JsonProperty("relations")]
        public Uri Relations { get; set; }
    }
}
