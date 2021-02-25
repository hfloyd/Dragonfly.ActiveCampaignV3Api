namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;

    [Serializable()]
    public class ActiveCampaignException : System.Exception, ISerializable
    {
        public enum ExType
        {
            InvalidActionUrl,
            AuthorizationIssue,
            NoMatchingDataReturned,
            Unspecified,
            ApiServerError
        }

        public string RequestUrl { get; set; }
        public ActiveCampaignResponse Response { get; set; }

        public ExType ExceptionType { get; set; }
        public string ErrorCode { get; set; }

        /// <summary>
        /// Argument constructor with custom properties
        /// </summary>
        /// <param name="Message">This is the description of the exception</param>
        /// <param name="RequestUrl">Action URL requested</param>
        /// <param name="Response">ActiveCampaignResponse object with data from API call</param>
        /// <param name="ExceptionType">Classified type of the Exception</param>
        /// <param name="ErrorCode">Short code to identify error or related data</param>
        /// <param name="InnerException">Inner exception</param>
        public ActiveCampaignException(string Message, string RequestUrl, ActiveCampaignResponse Response, ExType ExceptionType = ExType.Unspecified, string ErrorCode = "", Exception InnerException = null) : base(Message, InnerException)
        {
            this.RequestUrl = RequestUrl;
            this.Response = Response;
            this.ExceptionType = ExceptionType;
            this.ErrorCode = ErrorCode;
        }

        public ActiveCampaignException(string Message, string RequestUrl, ExType ExceptionType = ExType.Unspecified, string ErrorCode = "", Exception InnerException = null) : base(Message, InnerException)
        {
            this.RequestUrl = RequestUrl;
            this.ExceptionType = ExceptionType;
            this.ErrorCode = ErrorCode;
        }

        public ActiveCampaignException(string Message, ExType ExceptionType = ExType.Unspecified, string ErrorCode = "", Exception InnerException = null) : base(Message, InnerException)
        {
            this.ExceptionType = ExceptionType;
            this.ErrorCode = ErrorCode;
        }

        #region Generic Exception constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActiveCampaignException() : base() { }
        /// <summary>
        /// Argument constructor
        /// </summary>
        /// <param name="Message">This is the description of the exception</param>
        public ActiveCampaignException(string Message) : base(Message) { }
        /// <summary>
        /// Argument constructor with inner exception
        /// </summary>
        /// <param name="Message">This is the description of the exception</param>
        /// <param name="InnerException">Inner exception</param>
        public ActiveCampaignException(string Message, Exception InnerException) : base(Message, InnerException) { }
        /// <summary>
        /// Argument constructor with serialization support
        /// </summary>
        /// <param name="Info">Instance of SerializationInfo</param>
        /// <param name="Context">Instance of StreamingContext</param>
        protected ActiveCampaignException(SerializationInfo Info, StreamingContext Context) : base(Info, Context) { }

        #endregion
    }
}
