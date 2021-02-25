namespace Dragonfly.ActiveCampaign.Commands
{
    using Dragonfly.ActiveCampaign.Models.Client;

    public class AddListCommand : ActiveCampaignRequest
	{
		public AddListCommand(string name, string senderName, string senderAddress, string senderCity, string senderCountry)
		{
			Name = name;
			SenderName = senderName;
			SenderAddr1 = senderAddress;
			SenderCity = senderCity;
			SenderCountry = senderCountry;
		}

		public string Name { get; }

		public string SenderName { get; }

		public string SenderAddr1 { get; }

		public string SenderCity { get; }

		public string SenderCountry { get; }

		public string SenderUrl { get; set; }

		public string SenderReminder { get; set; }

		public string SenderZip { get; set; }
	}
}