using Microsoft.AspNetCore.Mvc;
using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;
using sekerbankatm.Service.Abstract;
using sekerbankatm.Service.Concrete;

namespace sekerbankatm.Controllers;

[ApiController]
[Route("api/atm-machine")]
public class AtmMachineController : ControllerBase
{
    private readonly IAtmMachineService _atmMachineService;
    
    public AtmMachineController(IAtmMachineService atmMachineService)
    {
        _atmMachineService = atmMachineService;
    }
    
    // GET: api/AtmMachine
    [HttpGet("list")]
    public IActionResult GetAllAtmMachines()
    { 
        var atmMachines = _atmMachineService.GetAllAtmMachines2();
        return Ok(atmMachines);
    }
    
    // GET: api/AtmMachine/{id}
    [HttpGet("detail/{id}")]
    public IActionResult GetAtmMachineById(int id)
    {
        var atmMachines = _atmMachineService.GetAtmMachineById(id);
        if (atmMachines == null)
        {
            return NotFound();
        }
        return Ok(atmMachines);
    }

    // POST: api/AtmMachine
    [HttpPost("create")]
    public IActionResult Create(AtmMachineCreateDto dto)
    {
        _atmMachineService.CreateAtmMachine(dto);
        return Ok(dto);
    }

    // PUT: api/AtmMachine/{id}
    [HttpPut("update")]
    public IActionResult Update(AtmMachineUpdateDto dto)
    {
        var existingAtm = _atmMachineService.GetAtmMachineById(dto.Id);
        if (existingAtm == null)
        {
            return NotFound();
        }

        _atmMachineService.UpdateAtmMachine(dto);
        return Ok(existingAtm);
    }

    // DELETE: api/AtmMachine/{id}
    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {
        var existingAtmMachine = _atmMachineService.GetAtmMachineById(id);
        if (existingAtmMachine == null)
        {
            return NotFound();
        }

        _atmMachineService.DeleteAtmMachine(id);
        return NoContent();
    }


}

