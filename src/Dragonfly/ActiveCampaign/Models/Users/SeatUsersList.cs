﻿namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    //TODO: HOLD - Needs more JSON examples for SeatUsers
    public class SeatUsersList
    {
        [JsonProperty("seatUsers")]
        public List<object> SeatUsers { get; set; }
    }
}