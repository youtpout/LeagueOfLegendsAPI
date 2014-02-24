﻿using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Summoner.Models.DTO;

namespace PortableLeagueApi.Summoner.Models
{
    public class Rune : LeagueApiModel, IRune
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public int Tier { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            autoMapperService.CreateMap<RuneDto, IRune>().As<Rune>();
            autoMapperService.CreateMap<RuneDto, Rune>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}