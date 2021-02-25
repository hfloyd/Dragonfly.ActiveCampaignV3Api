namespace Dragonfly.ActiveCampaign.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Request to ActiveCampaign API - Used for GET and POST operations
    /// </summary>
    /// <typeparam name="T">Model for Result</typeparam>
    public abstract class ActiveCampaignRequest<T> : IActiveCampaignRequest
    {
        public string ApiKey { get; set; }

        public string ApiAction { get; set; }

        public string ApiOutput { get; set; }

        public IDictionary<string, string> Fields { get; }

        public ActiveCampaignConnection Connection { get; }

        public ActiveCampaignResult<T> Result { get; set; }

        public ActiveCampaignResult<T> PreviousResult { get; set; }

        protected ActiveCampaignRequest(ActiveCampaignConnection Connection)
        {
            this.Fields = new Dictionary<string, string>();
            this.Connection = Connection;
        }

        internal abstract IEnumerable<string> LinkedDataParams();

        internal virtual string SerializePostData()
        {
            return "";
        }

        private protected void Reset()
        {
            this.PreviousResult = this.Result;
            this.Result = null;
            this.Fields.Clear();
        }


    }

    internal interface IActiveCampaignRequest
    {
        string ApiKey { get; set; }

        string ApiAction { get; set; }

        string ApiOutput { get; set; }

        IDictionary<string, string> Fields { get; }

        ActiveCampaignConnection Connection { get; }
    }
}
