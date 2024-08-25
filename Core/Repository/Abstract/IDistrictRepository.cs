using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Core.Repository.Abstract;

public interface IDistrictRepository
{
     District GetDistrictById(int id);
     IEnumerable<District> GetAllDistricts();
     IEnumerable<DistrictResponseDto> GetDistrictsByCityId(int id);

}