using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Service.Abstract;

public interface IAtmMachineService
{
     void CreateAtmMachine(AtmMachineCreateDto dto);
     void UpdateAtmMachine(AtmMachineUpdateDto dto);
     void DeleteAtmMachine(int id);
     IEnumerable<AtmMachineResponseDto> GetAllAtmMachines();
     AtmMachineResponseDto GetAtmMachineById(int atmMachineId);
     IEnumerable<AtmMachineResponseDto> GetAllAtmMachines2();
}
