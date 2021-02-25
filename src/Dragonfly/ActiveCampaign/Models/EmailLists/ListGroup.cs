namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class ListGroup
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("list")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long List { get; set; }

        [JsonProperty("group")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Group { get; set; }

        [JsonProperty("p_list_add")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PListAdd { get; set; }

        [JsonProperty("p_list_edit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PListEdit { get; set; }

        [JsonProperty("p_list_delete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PListDelete { get; set; }

        [JsonProperty("p_list_sync")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PListSync { get; set; }

        [JsonProperty("p_list_filter")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PListFilter { get; set; }

        [JsonProperty("p_message_add")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PMessageAdd { get; set; }

        [JsonProperty("p_message_edit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PMessageEdit { get; set; }

        [JsonProperty("p_message_delete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PMessageDelete { get; set; }

        [JsonProperty("p_message_send")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PMessageSend { get; set; }

        [JsonProperty("p_subscriber_add")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PSubscriberAdd { get; set; }

        [JsonProperty("p_subscriber_edit")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PSubscriberEdit { get; set; }

        [JsonProperty("p_subscriber_delete")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PSubscriberDelete { get; set; }

        [JsonProperty("p_subscriber_import")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PSubscriberImport { get; set; }

        [JsonProperty("p_subscriber_approve")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long PSubscriberApprove { get; set; }

        [JsonProperty("links")]
        public ListGroupLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<EmailList> GetList(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.List.ToString();
            var result = Connection.ExecuteGetRequest<EmailList>(linkedUrl);
            return result;
        }

        public ActiveCampaignResult<Group> GetGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Group.ToString();
            var result = Connection.ExecuteGetRequest<Group>(linkedUrl);
            return result;
        }

        #endregion
    }

    public  class ListGroupLinks
    {
        [JsonProperty("list")]
        public Uri List { get; set; }

        [JsonProperty("group")]
        public Uri Group { get; set; }
    }
}
