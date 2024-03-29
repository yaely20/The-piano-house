﻿using System.Numerics;
using The_Piano_house.Core.Entities;

namespace The_piano_house.Core.Entities
{
    public class Provider :BaseModel
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public List<MusicalInstrument> MusicalInstruments { get; set; }
    }
}
