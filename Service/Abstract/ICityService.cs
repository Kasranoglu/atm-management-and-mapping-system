using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Service.Abstract;

public interface ICityService
{
     CityResponseDto GetCityById(int id);
     IEnumerable<CityResponseDto> GetAllCities();
}