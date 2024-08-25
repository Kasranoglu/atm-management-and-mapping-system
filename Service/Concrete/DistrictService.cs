using sekerbankatm.Core.Dtos;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Core.Repository.Concrete;
using sekerbankatm.Data.Entities;
using sekerbankatm.Service.Abstract;

namespace sekerbankatm.Service.Concrete;

public class DistrictService : IDistrictService
{
    private readonly IDistrictRepository _districtRepository;

    public DistrictService(IDistrictRepository districtRepository)
    {
        _districtRepository = districtRepository;
    }
    
    public CityResponseDto GetDistrictById(int id)
    {
        var district = _districtRepository.GetDistrictById(id);
        var districtDto = new CityResponseDto
        {   
            Id = district.Id,
            Name = district.Name,
        };
        return districtDto;
    }

    public IEnumerable<CityResponseDto> GetAllDistricts()
    {
        var districts = _districtRepository.GetAllDistricts();
        var districtsDto = districts.Select(d => new CityResponseDto
        {   
            Id = d.Id,
            Name = d.Name,
        });
        return districtsDto;
    }
    
    public IEnumerable<DistrictResponseDto> GetDistrictsByCityId(int id)
    {
        var district = _districtRepository.GetDistrictsByCityId(id);
        return district;
    }
    
}