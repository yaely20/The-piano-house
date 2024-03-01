using AutoMapper;
using The_piano_house.Api.Models;
using The_piano_house.Core.Entities;

namespace The_piano_house.Mapping
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CustomerPostModel, Customer>();
            CreateMap<MusicalInstrumentPostModel, MusicalInstrument>();
            CreateMap<ProviderPostModel, Provider>();
        }
    }
}
