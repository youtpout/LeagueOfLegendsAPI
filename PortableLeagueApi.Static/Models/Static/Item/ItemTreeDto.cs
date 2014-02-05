﻿using Newtonsoft.Json;
namespace PortableLeagueApi.Static.Models.Static.Item
{
    public class ItemTreeDto
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}