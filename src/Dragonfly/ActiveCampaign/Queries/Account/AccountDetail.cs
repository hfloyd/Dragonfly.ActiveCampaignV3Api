namespace Dragonfly.ActiveCampaign.Models.Account.Queries
{
    public class AccountDetail
	{
		public int Id { get; set; }

		public string Username { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string LastLogin { get; set; }

		public string Lang { get; set; }

		public string Apikey { get; set; }

		public Groups Groups { get; set; }

		public string Apiurl { get; set; }

		public int Trackid { get; set; }

		public string Eventkey { get; set; }

		public string Cname { get; set; }
	}
}