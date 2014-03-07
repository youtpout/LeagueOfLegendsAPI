﻿using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Summoner
{
    public interface IMasteryPage : IApiModel
    {
        /// <summary>
        /// Mastery page Id.
        /// </summary>
        long Id { get; set; }
        /// <summary>
        /// List of mastery page talents associated with the mastery page.
        /// </summary>
        IList<ITalent> Talents { get; set; }
        /// <summary>
        /// Mastery page name.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        bool Current { get; set; }
    }
}