using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.DTOs;
using The_Piano_house.Core.Entities;

namespace The_Piano_house.Core
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
           
                CreateMap<CustumerDTO, Customer >().ReverseMap();

                CreateMap<MusicalInstrumentDTO, MusicalInstrument>().ReverseMap();

                CreateMap<ProviderDTO, Provider>().ReverseMap();

            
        }
    }
}
