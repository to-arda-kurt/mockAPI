using MockAPI.Data;

namespace MockAPI.Contracts;

public interface ICountriesRepository : IGenericRepository<Country>
{
        Task<Country> GetDetails(int id);
}