﻿using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Static.Rune
{
    public interface IRune : IApiModel
    {
        string Colloq { get; set; }
        bool ConsumeOnFull { get; set; }
        bool Consumed { get; set; }
        int Depth { get; set; }
        string Description { get; set; }
        IList<string> From { get; set; }
        IGold Gold { get; set; }
        string Group { get; set; }
        bool HideFromAll { get; set; }
        IImage Image { get; set; }
        bool InStore { get; set; }
        IList<string> Into { get; set; }
        IDictionary<string, bool> Maps { get; set; }
        string Name { get; set; }
        object Plaintext { get; set; }
        string RequiredChampion { get; set; }
        IRuneType RuneType { get; set; }
        int SpecialRecipe { get; set; }
        int Stacks { get; set; }
        IBasicDataStats Stats { get; set; }
        IList<string> Tags { get; set; }
    }
}