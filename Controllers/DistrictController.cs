using Microsoft.AspNetCore.Mvc;
using sekerbankatm.Service.Abstract;

namespace sekerbankatm.Controllers;

[ApiController]
[Route("api/district")]
public class DistrictController : ControllerBase
{
    private readonly IDistrictService _districtService;
    
    public DistrictController(IDistrictService districtService)
    {
        _districtService = districtService;
    }
    
    // GET: api/district
    [HttpGet("list",Name = "GetAllDistricts")]
    public IActionResult GetAll()
    {
        var districts = _districtService.GetAllDistricts();
        return Ok(districts);
    }
    
    // GET: api/district/detail/{id}
    [HttpGet("detail/{id}")]
    public IActionResult GetDistrictById(int id)
    {
        var district = _districtService.GetDistrictById(id);
        if (district == null)
        {
            return NotFound();
        }
        return Ok(district);
    }
    
    // GET: api/district/detail/{cityId}
    [HttpGet("get-districts-by-city-id/{cityId}")]
    public IActionResult GetDistrictsByCityId(int cityId)
    {
        var district = _districtService.GetDistrictsByCityId(cityId);
        if (district == null)
        {
            return NotFound();
        }
        return Ok(district);
    }
    
    
    
}