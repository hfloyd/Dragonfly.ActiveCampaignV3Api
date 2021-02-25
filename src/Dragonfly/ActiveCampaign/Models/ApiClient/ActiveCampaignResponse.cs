namespace Dragonfly.ActiveCampaign.Models
{
    public class ActiveCampaignResponse
    {
        public int ResultCode { get; set; }

        public string ResultMessage { get; set; }

        public string ResultOutput { get; set; }

        public override string ToString()
        {
            return $"{ResultCode} - Message: {ResultMessage} - Output: {ResultOutput}";
        }
    }
}