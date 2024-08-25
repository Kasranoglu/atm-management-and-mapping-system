using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Data;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Core.Repository.Concrete;

public class CityRepository : ICityRepository
{
    private readonly SekerBankAtmDbContext _dbContext;
    
    public CityRepository(SekerBankAtmDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public City GetCityById(int id)
    {
        return _dbContext.Cities.Find(id);
    }

    public IEnumerable<City> GetAllCities()
    {
        return _dbContext.Cities.ToList();    
    }
}