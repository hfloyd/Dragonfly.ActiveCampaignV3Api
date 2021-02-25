namespace Dragonfly.ActiveCampaign.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Models;
    using Newtonsoft.Json;

    //Uses the sync command - https://developers.activecampaign.com/reference?_ga=2.79471828.1564152.1611946105-1183065105.1584984488#create-or-update-contact-new
    public class CreateOrUpdateContact : ActiveCampaignRequest<UpdatedContact>
    {
        private string postEndPoint = "contact/sync";

        internal CreateOrUpdateContactPostData PostData { get; set; }


        public CreateOrUpdateContact(Contact ContactToSync, IEnumerable<FieldValueSet> UpdatedFieldValues, ActiveCampaignConnection Connection) : base(Connection)
        {
            //Set property data
            this.PostData = new CreateOrUpdateContactPostData();
            this.PostData.Contact = new ContactSet();
            this.PostData.Contact.Email = ContactToSync.Email;
            this.PostData.Contact.FirstName = ContactToSync.FirstName;
            this.PostData.Contact.LastName = ContactToSync.LastName;
            this.PostData.Contact.OrganizationId = ContactToSync.OrganizationId;
            this.PostData.Contact.Phone = ContactToSync.Phone;

            if (UpdatedFieldValues != null)
            { this.PostData.Contact.FieldValues = UpdatedFieldValues; }
            else
            {
                this.PostData.Contact.FieldValues = new List<FieldValueSet>();
            }

            //get result
            var result = this.Connection.ExecutePostRequest<UpdatedContact>(postEndPoint, this);
            this.Result = result;
        }

        internal override string SerializePostData()
        {
            return JsonConvert.SerializeObject(this.PostData);
        }

        internal override IEnumerable<string> LinkedDataParams()
        {
            return new List<string>();
        }
    }

    internal class CreateOrUpdateContactPostData
    {
        [JsonProperty("contact")]
        public ContactSet Contact { get; set; }
    }
    public class ContactSet
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("orgid")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        [Obsolete("(Deprecated) Please use Account-Contact end points")]
        public long OrganizationId { get; set; }

        [JsonProperty("fieldValues")]
        public IEnumerable<FieldValueSet> FieldValues { get; set; }
    }
    
    public class FieldValueSet
    {
        [JsonProperty("field")]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long FieldId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdatedContact
    {
        [JsonProperty("fieldValues")]
        public List<FieldValue> FieldValues { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }
    }
}