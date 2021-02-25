namespace EyeSoft.ActiveCampaign.Commanding.Contact.Models
{
    using Dragonfly.ActiveCampaign.Models.ApiClient;

    public class DeleteContactCommand : ActiveCampaignRequest
	{
		public DeleteContactCommand(int id)
		{
			Id = id;
		}

		public int Id { get; }
	}
}