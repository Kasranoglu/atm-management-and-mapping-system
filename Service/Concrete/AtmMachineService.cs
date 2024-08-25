using sekerbankatm.Core.Dtos;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Data.Entities;
using sekerbankatm.Service.Abstract;

namespace sekerbankatm.Service.Concrete;

public class AtmMachineService : IAtmMachineService
{
    private readonly IAtmMachineRepository _atmMachineRepository;

    public AtmMachineService(IAtmMachineRepository atmMachineRepository)
    {
        _atmMachineRepository = atmMachineRepository;
    }
    
    public void CreateAtmMachine(AtmMachineCreateDto dto)
    {
        var atmMachine = new AtmMachine
        {
            Name = dto.Name,
            Latitude = dto.Latitude,
            Longitude = dto.Longitude,
            Adress = dto.Adress,
            CityId = dto.CityId,
            DistrictId = dto.DistrictId,
            IsActive = dto.IsActive
        };

        _atmMachineRepository.CreateAtmMachine(atmMachine);
    }

    public void UpdateAtmMachine(AtmMachineUpdateDto dto)
    {

        _atmMachineRepository.UpdateAtmMachine(dto);
    }

    public void DeleteAtmMachine(int id)
    {
       
        _atmMachineRepository.DeleteAtmMachine(id);
    }

    public IEnumerable<AtmMachineResponseDto> GetAllAtmMachines()
    {
        var atmMachines = _atmMachineRepository.GetAllAtmMachines();

        var atmMachineGetAllDtos = atmMachines.Select(a => new AtmMachineResponseDto
        {
            Id = a.Id,
            Name = a.Name,
            Longitude = a.Longitude,
            Latitude = a.Latitude,
            Adress = a.Adress,
            IsActive = a.IsActive,
            CityId = a.CityId,
            CityName = a.City.Name,
            DistrictId = a.DistrictId,
            DistrictName = a.District.Name,
        });

        return atmMachineGetAllDtos.ToList();
    }
    
    public IEnumerable<AtmMachineResponseDto> GetAllAtmMachines2()
    {
        var atmMachines = _atmMachineRepository.GetAllAtmMachines2();
        return atmMachines;
    }

    public AtmMachineResponseDto GetAtmMachineById(int atmMachineId)
    {
        var atmMachines = _atmMachineRepository.GetAtmMachineById(atmMachineId);
        return atmMachines;
    }
    

}