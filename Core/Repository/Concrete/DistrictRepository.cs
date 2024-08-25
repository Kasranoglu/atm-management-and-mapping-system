using sekerbankatm.Core.Dtos;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Data;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Core.Repository.Concrete;

public class DistrictRepository : IDistrictRepository
{
    private readonly SekerBankAtmDbContext _dbContext;
    
    public DistrictRepository(SekerBankAtmDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public District GetDistrictById(int id)
    {
        return _dbContext.Districts.Find(id);
    }

    public IEnumerable<District> GetAllDistricts()
    {
        return _dbContext.Districts.ToList();    
    }

    public IEnumerable<DistrictResponseDto> GetDistrictsByCityId(int id)
    {
        // return _dbContext.Districts.Where(d => d.CityId == id).ToList();
        var query = from distrct in _dbContext.Districts
            join city in _dbContext.Cities on distrct.CityId equals city.Id
            where distrct.CityId == id
            select new DistrictResponseDto()
            {
                Id = distrct.Id,
                Name = distrct.Name,
                CityId = distrct.CityId,
                CityName = city.Name,

            };
        return query.ToList();
    }
}