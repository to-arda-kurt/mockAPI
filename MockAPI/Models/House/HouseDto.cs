
using MockAPI.Models.Country;

namespace MockAPI.Models.House;

public class HouseDto : BaseHouseDto
{
        public int Id { get; set; }

        public GetCountryDto Country { get; set; }

}