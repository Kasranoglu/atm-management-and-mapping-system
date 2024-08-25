using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Service.Abstract;

public interface IDistrictService
{
     CityResponseDto GetDistrictById(int id);
     IEnumerable<CityResponseDto> GetAllDistricts();
     IEnumerable<DistrictResponseDto> GetDistrictsByCityId(int id);

}