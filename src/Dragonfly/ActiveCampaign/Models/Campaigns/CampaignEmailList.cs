namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class CampaignEmailList
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("user")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long User { get; set; }

        [JsonProperty("list")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long List { get; set; }

        [JsonProperty("campaign")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Campaign { get; set; }

        [JsonProperty("campaignid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long CampaignId { get; set; }

        [JsonProperty("listid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ListId { get; set; }

        [JsonProperty("userid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long UserId { get; set; }

        [JsonProperty("list_amt")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long ListAmt { get; set; }

        [JsonProperty("cdate")]
        public object CDate { get; set; }

        [JsonProperty("udate")]
        public object UDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public CampaignEmailListLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<User> GetUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.User.ToString();
            var result = Connection.ExecuteGetRequest<User>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<EmailList> GetList(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.List.ToString();
            var result = Connection.ExecuteGetRequest<EmailList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<Campaign> GetCampaign(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Campaign.ToString();
            var result = Connection.ExecuteGetRequest<Campaign>(linkedUrl);
            return result;
        }

        #endregion

    }

    public  class CampaignEmailListLinks
    {
        [JsonProperty("user")]
        public Uri User { get; set; }

        [JsonProperty("list")]
        public Uri List { get; set; }

        [JsonProperty("campaign")]
        public Uri Campaign { get; set; }
    }
}
