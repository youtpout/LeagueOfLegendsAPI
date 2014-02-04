﻿using Newtonsoft.Json;

namespace PortableLeagueAPI.Models.Stats
{
    public class RankedStatsDto
    {
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// List of aggregated stats summarized by champion.
        /// </summary>
        [JsonProperty("champions")]
        public ChampionStatsDto[] Champions { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}
