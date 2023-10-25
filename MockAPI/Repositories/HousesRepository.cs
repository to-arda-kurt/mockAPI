using Microsoft.EntityFrameworkCore;
using MockAPI.Contracts;
using MockAPI.Data;

namespace MockAPI.Repositories;

public class HousesRepository : GenericRepository<House>, IHousesRepository
{
    private readonly MockApiDbContext _context;
    
    public HousesRepository(MockApiDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<House> GetDetails(int id)
    {
        return await _context.Houses
                    .Include(q =>q.Country)
                    .FirstOrDefaultAsync(q => q.Id == id);
    }
}