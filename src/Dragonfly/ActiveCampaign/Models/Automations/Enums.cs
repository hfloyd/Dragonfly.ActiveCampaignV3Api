namespace Dragonfly.ActiveCampaign.Models
{
	public enum ContactAutomationStatus
    {
		Active = 1,
		Removed = 2
	}

    public enum AutomationStatus
    {
        Active = 1,
        Inactive = 2
    }

    public enum BatchId
    {
        Completed
    }

    public enum SendType { Empty, Imm };

    //public enum Timelimit { Nolimit };

    //public enum Durt { Day, Minute, Week };

    public enum WaitType { For, Until };

}