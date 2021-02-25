namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    /// <summary>
    /// Returned from 'SegmentsRequest'
    /// </summary>
    public class SegmentsList
    {
        [JsonProperty("segments")]
        public List<Segment> Segments { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }


}

