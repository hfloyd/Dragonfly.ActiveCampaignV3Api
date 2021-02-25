namespace EyeSoft.ActiveCampaign.Commanding.Contact.Models
{
	using System.Collections.Generic;
    using Dragonfly.ActiveCampaign.Models;
    using Dragonfly.ActiveCampaign.Models.ApiClient;

    public class AddContactCommand : ActiveCampaignRequest<>
    {
		public AddContactCommand(int id, string email)
		{
			Id = id;
			Email = email;

			Fields = new Dictionary<string, string>();
        }

		public int Id { get; }

		public string Email { get; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Phone { get; set; }

		public string Orgname { get; set; }

		public string Tags { get; set; }

        public string PValues { get; set; }

        public IDictionary<string, string> Fields { get; }
	}
}
