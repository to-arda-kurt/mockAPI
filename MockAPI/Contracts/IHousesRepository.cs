using MockAPI.Data;

namespace MockAPI.Contracts;

public interface IHousesRepository : IGenericRepository<House>
{
    Task<House> GetDetails(int id);
}