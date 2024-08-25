using sekerbankatm.Core.Dtos;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Core.Repository.Concrete;
using sekerbankatm.Data.Entities;
using sekerbankatm.Service.Abstract;

namespace sekerbankatm.Service.Concrete;

public class CityService : ICityService
{
    private readonly ICityRepository _cityRepository;

    public CityService(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public CityResponseDto GetCityById(int id)
    {
        var city = _cityRepository.GetCityById(id);
        var cityDto = new CityResponseDto
        {
            Id = city.Id,
            Name = city.Name,
        };
        return cityDto;
    }

    public IEnumerable<CityResponseDto> GetAllCities()
    {
        var cities = _cityRepository.GetAllCities();
        var citiesDto = cities.Select
        (c => new CityResponseDto
        {
            Id = c.Id,
            Name = c.Name 
        });
    return citiesDto;
    }
}