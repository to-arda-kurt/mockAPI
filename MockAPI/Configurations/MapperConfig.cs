using AutoMapper;
using MockAPI.Data;
using MockAPI.Models.Country;
using MockAPI.Models.House;

namespace MockAPI.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        // Country
        CreateMap<Country, CreateCountryDto>().ReverseMap();
        CreateMap<Country, GetCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();
        
        // House
        CreateMap<House, HouseDto>().ReverseMap();

    }
}