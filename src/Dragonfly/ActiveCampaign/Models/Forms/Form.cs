namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Form
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("address")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("actiondata")]
        public ActionData ActionData { get; set; }

        [JsonProperty("submit")]
        public string Submit { get; set; }

        [JsonProperty("submitdata")]
        public SubmitData SubmitData { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("button")]
        public string Button { get; set; }

        [JsonProperty("thanks")]
        public string Thanks { get; set; }

        [JsonProperty("style")]
        public FormStyle Style { get; set; }

        [JsonProperty("options")]
        public FormOptions Options { get; set; }

        [JsonProperty("cfields")]
        public List<CField> CFields { get; set; }

        [JsonProperty("parentformid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ParentFormId { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("addressid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long AddressId { get; set; }

        [JsonProperty("cdate")]
        public DateTimeOffset CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("links")]
        public FormLinks Links { get; set; }

        #region Linked Data Methods
        public ActiveCampaignResult<Address> GetAddress(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Address.ToString();
            var result = Connection.ExecuteGetRequest<Address>(linkedUrl);
            return result;
        }

        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params for FormRequest?
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

    public class FormLinks
    {
        [JsonProperty("address")]
        public Uri Address { get; set; }
    }

    public class ActionData
    {
        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }
    }

    public class Action
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("list")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long List { get; set; }

        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }
    }

    public class CField
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public string Header { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
        public string Html { get; set; }

        [JsonProperty("default_text", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultText { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CFieldRequired { get; set; }
    }

    public class FormOptions
    {
        [JsonProperty("blanks_overwrite")]
        public bool BlanksOverwrite { get; set; }

        [JsonProperty("confaction")]
        public string Confaction { get; set; }

        [JsonProperty("sendoptin")]
        public bool SendOptIn { get; set; }

        [JsonProperty("optin_id")]
        public long OptInId { get; set; }

        [JsonProperty("optin_created")]
        public bool OptInCreated { get; set; }

        [JsonProperty("confform")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ConfForm { get; set; }
    }

    public class FormStyle
    {
        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("dark")]
        public bool Dark { get; set; }

        [JsonProperty("fontcolor")]
        public string FontColor { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("border")]
        public Border Border { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("ac_branding")]
        public bool AcBranding { get; set; }

        [JsonProperty("button")]
        public Button Button { get; set; }
    }

    public class Border
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("radius")]
        public long Radius { get; set; }
    }

    public class Button
    {
        [JsonProperty("padding")]
        public long Padding { get; set; }

        [JsonProperty("background")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Background { get; set; }

        [JsonProperty("fontcolor")]
        public string FontColor { get; set; }

        [JsonProperty("border")]
        public Border Border { get; set; }
    }

    public class SubmitData
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
