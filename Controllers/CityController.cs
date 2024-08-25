using Microsoft.AspNetCore.Mvc;
using sekerbankatm.Data.Entities;
using sekerbankatm.Service.Abstract;

namespace sekerbankatm.Controllers;

[ApiController]
[Route("api/city")]
public class CityController : ControllerBase
{
    private readonly ICityService _cityService;
    
    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }
    
    // GET: api/city/list
    [HttpGet("list",Name = "GetAllCities")]
    public IActionResult GetAll()
    {
        var cities = _cityService.GetAllCities();
        return Ok(cities);
    }
    
    // GET: api/detail/{id}
    [HttpGet("detail/{id}")]
    public IActionResult GetCityById(int id)
    {
        var city = _cityService.GetCityById(id);
        if (city == null)
        {
            return NotFound();
        }
        return Ok(city);
    }
    
    
}