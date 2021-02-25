namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ActivityRecipientsList
    {
        [JsonProperty("activityRecipients")]
        public List<ActivityRecipient> ActivityRecipients { get; set; }
    }

}