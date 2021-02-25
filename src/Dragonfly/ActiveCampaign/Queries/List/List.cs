namespace Dragonfly.ActiveCampaign.Query.Models
{
	using System;

	public class List
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Cdate { get; set; }

		public string Private { get; set; }

		public string Userid { get; set; }

		public int SubscriberCount { get; set; }
	}
}