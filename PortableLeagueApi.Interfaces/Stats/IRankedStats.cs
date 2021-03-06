﻿using System;
using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Extensions;

namespace PortableLeagueApi.Interfaces.Stats
{
    public interface IRankedStats : IHasSummonerId
    {
        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        DateTime ModifyDate { get; set; }
        /// <summary>
        /// List of aggregated stats summarized by champion.
        /// </summary>
        IList<IChampionStats> Champions { get; set; }
    }
}