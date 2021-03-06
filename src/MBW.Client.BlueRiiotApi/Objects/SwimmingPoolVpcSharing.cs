﻿using Newtonsoft.Json;

namespace MBW.Client.BlueRiiotApi.Objects
{
    public class SwimmingPoolVpcSharing
    {
        [JsonProperty("followup_settings")]
        public VpcFollowupSettings FollowupSettings { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("sharing_status")]
        public string SharingStatus { get; set; }
    }
}