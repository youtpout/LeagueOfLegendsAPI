﻿using System;
using AutoMapper;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.League.Models.DTO;

namespace PortableLeagueApi.League.Models
{
    public class LeagueItem : LeagueApiModel, ILeagueItem
    {
        public bool IsFreshBlood { get; set; }
        public bool IsHotStreak { get; set; }
        public bool IsInactive { get; set; }
        public bool IsVeteran { get; set; }
        public DateTime LastPlayed { get; set; }
        public string LeagueName { get; set; }
        public int LeaguePoints { get; set; }
        public IMiniSeries MiniSeries { get; set; }
        public string PlayerOrTeamId { get; set; }
        public string PlayerOrTeamName { get; set; }
        public string QueueType { get; set; }
        public string Rank { get; set; }
        public string Tier { get; set; }
        public int Wins { get; set; }

        internal static void CreateMap(ILeagueAPI source)
        {
            Models.MiniSeries.CreateMap(source);

            Mapper.CreateMap<LeagueItemDto, ILeagueItem>().As<LeagueItem>();
            Mapper.CreateMap<LeagueItemDto, LeagueItem>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}
