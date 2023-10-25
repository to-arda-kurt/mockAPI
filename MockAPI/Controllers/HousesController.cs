using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockAPI.Contracts;
using MockAPI.Data;
using MockAPI.Models.House;

namespace MockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly IHousesRepository _housesRepository;
        private readonly IMapper _mapper;
       

        public HousesController(IHousesRepository housesRepository, IMapper mapper)
        {
            _housesRepository = housesRepository;
            _mapper = mapper;
        }

        // GET: api/Houses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetHouseDto>>> GetHouses()
        {
            var houses = await _housesRepository.GetAllAsync();
            var data = _mapper.Map<List<GetHouseDto>>(houses);
            return data;
        }

        // GET: api/Houses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HouseDto>> GetHouse(int id)
        {
            
            var house = await _housesRepository.GetDetails(id);

            if (house == null)
            {
                return NotFound();
            }
            var data = _mapper.Map<HouseDto>(house);
            return data;
        }

        // PUT: api/Houses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHouse(int id, UpdateHouseDto updateHouseDto)
        {
            if (id != updateHouseDto.Id)
            {
                return BadRequest();
            }

            var house = await _housesRepository.GetAsync(id);

            if (house == null)
            {
                return NotFound();
            }

            _mapper.Map(updateHouseDto, house);
            
            try
            {
                await _housesRepository.UpdateAsync(house);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await HouseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/Houses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<House>> PostHouse(CreateHouseDto createHouseDto)
        {
            var house = _mapper.Map<House>(createHouseDto);
            await _housesRepository.AddAsync(house);

            return CreatedAtAction("GetHouse", new { id = house.Id }, house);
        }

        // DELETE: api/Houses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHouse(int id)
        {
            var house = await _housesRepository.GetAsync(id);
            if (house == null)
            {
                return NotFound();
            }

            await _housesRepository.DeleteAsync(id);

            return NoContent();
        }

        private Task<bool> HouseExists(int id)
        {
            return _housesRepository.Exists(id);
        }
    }
}
