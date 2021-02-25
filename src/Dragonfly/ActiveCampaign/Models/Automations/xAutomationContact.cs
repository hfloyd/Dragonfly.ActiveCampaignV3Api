namespace Dragonfly.ActiveCampaign.Models.Automations
{
    using System;

    public class AutomationContact
	{
		public AutomationContact(int id, string email, AutomationContactStatus automationStatus, DateTime adddate, DateTime? remdate, int lastblock, DateTime lastdate)
		{
			Id = id;
			Email = email;
			AutomationStatus = automationStatus;
			AddDate = adddate;
			LastDate = lastdate;
			RemovedDate = remdate;
			LastBlock = lastblock;
		}

		public int Id { get; }

		public string Email { get; }

		public AutomationContactStatus AutomationStatus { get; }

		public DateTime AddDate { get; }

		public DateTime? RemovedDate { get; }

		public DateTime LastDate { get; }

		public int LastBlock { get; }
	}
}