namespace EyeSoft.ActiveCampaign.Commanding.Contact.Models
{
    using Dragonfly.ActiveCampaign.Models.ApiClient;

    public class RemoveTagsCommand : ActiveCampaignRequest
    {
        public RemoveTagsCommand(string email, params string[] tags)
        {
            Email = email;
            Tags = tags;
        }

        public string Email { get; }

        public string[] Tags { get; set; }
    }
}