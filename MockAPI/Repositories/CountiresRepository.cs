using Microsoft.EntityFrameworkCore;
using MockAPI.Contracts;
using MockAPI.Data;

namespace MockAPI.Repositories;

public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
{
    private readonly MockApiDbContext _context;
    
    public CountriesRepository(MockApiDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Country> GetDetails(int id)
    {
        return await _context.Countries
                    .Include(q =>q.Houses)
                    .FirstOrDefaultAsync(q => q.Id == id);
    }
}