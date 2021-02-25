namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class User
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("localZoneid")]
        public string LocalZoneId { get; set; }

        [JsonProperty("password_updated_utc_timestamp")]
        public DateTimeOffset PasswordUpdatedUtcTimestamp { get; set; }

        [JsonProperty("cdate")]
        public object CDate { get; set; }

        [JsonProperty("udate")]
        public DateTimeOffset UDate { get; set; }

        [JsonProperty("mfaEnabled")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long MfaEnabled { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }

        #region Linked Data Methods

        public ActiveCampaignResult<EmailListsList> GetLists(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Lists.ToString();
            var result = Connection.ExecuteGetRequest<EmailListsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<UserGroup> GetUserGroup(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.UserGroup.ToString();
            var result = Connection.ExecuteGetRequest<UserGroup>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealGroupTotalsList> GetDealGroupTotals(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealGroupTotals.ToString();
            var result = Connection.ExecuteGetRequest<DealGroupTotalsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealGroupUsersList> GetDealGroupUsers(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealGroupUsers.ToString();
            var result = Connection.ExecuteGetRequest<DealGroupUsersList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<ConfigsList> GetConfigs(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.Configs.ToString();
            var result = Connection.ExecuteGetRequest<ConfigsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<DealConnectionsList> GetDealConnection(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.DealConnection.ToString();
            var result = Connection.ExecuteGetRequest<DealConnectionsList>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<UserConversationsPermission> GetUserConversationsPermission(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.UserConversationsPermission.ToString();
            var result = Connection.ExecuteGetRequest<UserConversationsPermission>(linkedUrl);
            return result;
        }
        public ActiveCampaignResult<SeatUsersList> GetSeatUser(ActiveCampaignConnection Connection)
        {
            var linkedUrl = this.Links.SeatUser.ToString();
            var result = Connection.ExecuteGetRequest<SeatUsersList>(linkedUrl);
            return result;
        }
        
        #endregion

        #region Sideloading Params

        //TODO: HOLD - Add Sideloading Params for UserRequest?
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

    public class UserLinks
    {
        [JsonProperty("lists")]
        public Uri Lists { get; set; }

        [JsonProperty("userGroup")]
        public Uri UserGroup { get; set; }

        [JsonProperty("dealGroupTotals")]
        public Uri DealGroupTotals { get; set; }

        [JsonProperty("dealGroupUsers")]
        public Uri DealGroupUsers { get; set; }

        [JsonProperty("configs")]
        public Uri Configs { get; set; }

        [JsonProperty("dealConnection")]
        public Uri DealConnection { get; set; }

        [JsonProperty("userConversationsPermission")]
        public Uri UserConversationsPermission { get; set; }

        [JsonProperty("seatUser")]
        public Uri SeatUser { get; set; }
    }
}
