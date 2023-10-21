using MockAPI.Models.House;

namespace MockAPI.Models.Country;

public class CountryDto : BaseCountryDto
{
    public int Id { get; set; }
    
    public List<HouseDto> Houses { get; set; }
}
