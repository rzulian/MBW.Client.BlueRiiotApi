﻿using System.Collections.Generic;
using MBW.Client.BlueRiiotApi.Objects;
using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.RequestsResponses
{
    public class SwimmingPoolFeedGetResponse
    {
        [JsonProperty("data")]
        public List<SwimmingPoolFeedItem> Data { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("swimming_pool_id")]
        public string SwimmingPoolId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}