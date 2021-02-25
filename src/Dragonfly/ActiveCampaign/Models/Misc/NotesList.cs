namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class NotesList
    {
        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

  
}
