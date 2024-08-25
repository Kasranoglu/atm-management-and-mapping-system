using sekerbankatm.Data.Entities;

namespace sekerbankatm.Core.Repository.Abstract;

public interface ICityRepository
{
     City GetCityById(int id);
     IEnumerable<City> GetAllCities();
}