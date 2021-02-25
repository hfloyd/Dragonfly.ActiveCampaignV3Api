namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class FieldValue
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("contact")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Contact { get; set; }

        [JsonProperty("field")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Field { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("created_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UpdatedBy { get; set; }

        [JsonProperty("owner")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Owner { get; set; }

        [JsonProperty("links")]
        public FieldValueLinks Links { get; set; }


        #region Linked Data Methods
        public ActiveCampaignResult<Field> GetField(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Field.ToString();
            var result = Connection.ExecuteGetRequest<Field>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<Owner> GetOwner(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Owner.ToString();
            var result = Connection.ExecuteGetRequest<Owner>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params for FieldValueRequest?
        //public enum LinkedData
        //{
        //    BounceLogs,

        //}

        //internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<XX.LinkedData> DataList)
        //{
        //    var list = new List<string>();

        //    foreach (var item in DataList)
        //    {
        //        switch (item)
        //        {
        //            case LinkedData.BounceLogs:
        //                list.Add("bounceLogs");
        //                break;

        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }

        //    return list;
        //}

        #endregion
    }

    public class FieldValueLinks
    {
        [JsonProperty("owner")]
        public Uri Owner { get; set; }

        [JsonProperty("field")]
        public Uri Field { get; set; }
    }
}
