namespace Dragonfly.ActiveCampaign.Models.Account.Queries
{
    using Dragonfly.ActiveCampaign.Models.ApiClient;

    public class AccountQueryClient : ActiveCampaignRestClient, IAccountQueryClient
	{
		public AccountQueryClient(ActiveCampaignConnection connection)
			: base(connection)
		{
		}

		public AccountDetail GetAccount()
		{
			return ExecuteGetRequest<AccountDetail>("user_me", new UserMe());
		}
	}
}