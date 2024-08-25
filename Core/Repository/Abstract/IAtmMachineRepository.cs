using sekerbankatm.Core.Dtos;
using sekerbankatm.Data.Entities;

namespace sekerbankatm.Core.Repository.Abstract;

public interface IAtmMachineRepository
{   
     void CreateAtmMachine(AtmMachine atmMachine);
     void UpdateAtmMachine(AtmMachineUpdateDto atmMachine);
     void DeleteAtmMachine(int atmId);
     AtmMachineResponseDto GetAtmMachineById(int id);
     IEnumerable<AtmMachine> GetAllAtmMachines();
     IEnumerable<AtmMachineResponseDto> GetAllAtmMachines2();

}