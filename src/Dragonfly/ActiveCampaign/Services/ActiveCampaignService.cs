namespace Dragonfly.ActiveCampaign
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Queries;


    public class ActiveCampaignService : IDisposable
    {
        public ActiveCampaignConnection Connection { get; set; }
        public ActiveCampaignService(ActiveCampaignConnection AcConnection)
        {
            this.Connection = AcConnection;
        }

        public ActiveCampaignService(string AccountApiUrl, string ApiKey)
        {
            var conn = new ActiveCampaignConnection(AccountApiUrl, ApiKey);
            this.Connection = conn;
        }

        #region Query Methods

        #region Automations
        //public Automation GetAutomation(int AutomationId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Automation> GetAutomations()
        //{
        //    //var request = new AutomationRequest();

        //    //return ExecuteGetRequest<Automations>("automation_list", request).Data.OrderBy(x => x.Id);

        //    throw new NotImplementedException();

        //}
        #endregion

        #region Contacts

        //public IEnumerable<AutomationContact> GetContactsInAutomation(int AutomationId)
        //{
        //    //var request = new AutomationContactListRequest(AutomationId);

        //    //return ExecuteGetRequest<AutomationContactList>("automation_contact_list", request)?.Data;

        //    throw new NotImplementedException();

        //}

        public Contact GetContact(string Email, bool FailSilently = false)
        {
            var errRef = $"ActiveCampaignService.GetContact(Email: {Email})";
            try
            {
                var req = new ContactRequest(this.Connection);
                req.GetSingle(Email);
                var result = req.Result;

                if (result.ResultData != null)
                {
                    if (result.ResultData.Contacts.Any())
                    {
                        var list = result.ResultData;
                        var contact = list.Contacts.First();
                        return contact;
                    }
                    else
                    {
                        if (FailSilently) { return null; }
                        else
                        {
                            var msg = $"No Contact found matching email address";
                            throw new ActiveCampaignException(msg, ActiveCampaignException.ExType.NoMatchingDataReturned, "Contact");
                        }
                    }
                }
                else
                {
                    if (FailSilently) { return null; }
                    else
                    {
                        var msg = $"ResultData IS NULL";
                        throw new ActiveCampaignException(msg);
                    }
                }
            }
            catch (Exception e)
            {
                if (FailSilently) { return null; }
                else
                {
                    var msg = $"ERROR in {errRef} : {e.Message}";
                    throw new ActiveCampaignException(msg, e);
                }
            }

        }

        //IEnumerable<Contact> GetContacts(int page = 0, string filterField = null, object[] filterValues = null)
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<Contact> GetContacts()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<Contact> GetContacts(int page = 0, params int[] ids)
        //{
        //    throw new NotImplementedException();
        //}


        //IEnumerable<PaginatedContacts.Contact> GetContactsPaginated(int page = 0, int pageSize = 20, int filter = 0, bool isPublic = true)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        #endregion

        #region Command Methods

        #region Automations
        //ActiveCampaignResponse AddContactToAutomation(string ContactEmail, int AutomationId)
        //{
        //    throw new NotImplementedException();
        //}

        //ActiveCampaignResponse RemoveContactFromAutomation(string ContactEmail, int AutomationId)
        //{
        //    // return ExecutePostRequest<ActiveCampaignResponse>("automation_contact_remove", new AutomationRemoveContact(contactEmail, automation));
        //    throw new NotImplementedException();
        //}

        #endregion

        #region Contacts

        public ActiveCampaignResponse AddContact(Contact NewContact)
        {
            throw new NotImplementedException();
            // return ExecutePostRequest<ActiveCampaignResponse>("contact_add", command);
        }

        public ActiveCampaignResponse UpdateContactData(Contact NewContact)
        {                                               
            throw new NotImplementedException();
            //return ExecutePostRequest<ActiveCampaignResponse>("contact_sync", command);
        }

        public ActiveCampaignResponse DeleteContact(int id)
        {
            throw new NotImplementedException();
            //  return ExecuteGetRequest<ActiveCampaignResponse>("contact_delete", new DeleteContactCommand(id));
        }

        public ActiveCampaignResponse AddTagsToContact(int ContactId, List<string> Tags)
        {
            throw new NotImplementedException();
            // return ExecutePostRequest<ActiveCampaignResponse>("contact_tag_add", command);
        }

        public ActiveCampaignResponse RemoveTagsFromContact(int ContactId, List<string> Tags)
        {
            throw new NotImplementedException();
            // return ExecutePostRequest<ActiveCampaignResponse>("contact_tag_remove", command);
        }
        #endregion

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Connection?.Dispose();
        }

        #endregion
    }
}
