namespace Dragonfly.ActiveCampaign.Models.Contacts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Newtonsoft.Json;

    public class PaginatedContacts : ActiveCampaignResponse
    {
        public object Paginator { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; }

        public int Total { get; set; }

        public int Cnt { get; set; }

        [JsonProperty(PropertyName = "Rows")]
        public List<Contact> Contacts { get; set; }

        [DebuggerDisplay("{Email}")]
        public class Contact
        {
            private const string NullDateString = "0000-00-00 00:00:00";

            public int Id { get; set; }

            public string Email { get; set; }

            [JsonProperty(PropertyName = "first_name")]
            public string FirstName { get; set; }

            [JsonProperty(PropertyName = "last_name")]
            public string LastName { get; set; }

            [JsonProperty(PropertyName = "sdate")]
            public string SubscribedDate { get; set; }

            public DateTime? Subscribed => ConvertDateTime(SubscribedDate);

            [JsonProperty(PropertyName = "udate")]
            public string UnsubscribedDate { get; set; }

            public DateTime? Unsubscribed => ConvertDateTime(UnsubscribedDate);

            [JsonProperty(PropertyName = "cdate")]
            public DateTime Creation { get; set; }

            public string Ua { get; set; }

            private DateTime? ConvertDateTime(string dateTimeString)
            {
                if (string.IsNullOrEmpty(dateTimeString) || dateTimeString == NullDateString)
                {
                    return null;
                }

                return DateTime.Parse(dateTimeString);
            }

            public string Phone { get; set; }

            public string Orgid { get; set; }

            public string Orgname { get; set; }

            public string SegmentioId { get; set; }

            public string BouncedHard { get; set; }

            public string BouncedSoft { get; set; }

            public string BouncedDate { get; set; }

            public string Ip { get; set; }

            public string Hash { get; set; }

            public string SocialdataLastcheck { get; set; }

            public string EmailLocal { get; set; }

            public string EmailDomain { get; set; }

            public string Sentcnt { get; set; }

            public string Rating { get; set; }

            public string RatingTstamp { get; set; }

            public int Gravatar { get; set; }

            public bool HasGravatar => Gravatar != 0;

            public int Deleted { get; set; }

            public bool IsDeleted => Deleted != 0;

            public string Adate { get; set; }

            public string Edate { get; set; }

            public string Ip4 { get; set; }

            public string Formid { get; set; }

            public string Name { get; set; }

            [JsonProperty(PropertyName = "CdateIso")]
            public DateTime CreationIso { get; set; }

            [JsonProperty(PropertyName = "SdateIso")]
            public string SubscribedDateIso { get; set; }

            public DateTime? SubscribedIso => ConvertDateTime(SubscribedDateIso);

            [JsonProperty(PropertyName = "UdateIso")]
            public string UnsubscribedDateIso { get; set; }

            public DateTime? UnsubscribedIso => ConvertDateTime(UnsubscribedDateIso);
        }
    }
}