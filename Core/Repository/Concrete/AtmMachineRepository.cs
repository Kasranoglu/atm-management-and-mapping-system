using Microsoft.EntityFrameworkCore;
using sekerbankatm.Core.Dtos;
using sekerbankatm.Core.Repository.Abstract;
using sekerbankatm.Data.Entities;
using sekerbankatm.Data;

namespace sekerbankatm.Core.Repository.Concrete;

public class AtmMachineRepository : IAtmMachineRepository
{
    private readonly SekerBankAtmDbContext _dbContext;
    
    public AtmMachineRepository(SekerBankAtmDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreateAtmMachine(AtmMachine atmMachine)
    {
        _dbContext.AtmMachines.Add(atmMachine);
        _dbContext.SaveChanges();
    }

    public void UpdateAtmMachine(AtmMachineUpdateDto dto)
    {
        var existingAtmMachine = _dbContext.AtmMachines.FirstOrDefault(x => x.Id == dto.Id);
        if (existingAtmMachine != null)
        {
            existingAtmMachine.Id = dto.Id;
            existingAtmMachine.Name = dto.Name;
            existingAtmMachine.Latitude = dto.Latitude;
            existingAtmMachine.Longitude = dto.Longitude;
            existingAtmMachine.Adress = dto.Adress;
            existingAtmMachine.CityId = dto.CityId;
            existingAtmMachine.DistrictId = dto.DistrictId;
            existingAtmMachine.IsActive = dto.IsActive;
        

        //    _dbContext.Entry(existingAtmMachine).CurrentValues.SetValues(atmMachine);
            _dbContext.SaveChanges();
        }
    }

    public void DeleteAtmMachine(int id)
    {
        var atmMachine = _dbContext.AtmMachines.FirstOrDefault(x => x.Id == id);
        if (atmMachine != null)
        {
            _dbContext.AtmMachines.Remove(atmMachine);
            _dbContext.SaveChanges();
        }
    }

    public AtmMachineResponseDto GetAtmMachineById(int id)
    {
        var query = this.GetQueryable();
        
      // return query.Where(x => x.Id == id).FirstOrDefault();
      return query.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<AtmMachine> GetAllAtmMachines()
    {
        
            return _dbContext.AtmMachines.Include(x=>x.City).Include(x=>x.District).ToList();
        
    }
    
    public IEnumerable<AtmMachineResponseDto> GetAllAtmMachines2()
    {
        var query = this.GetQueryable();
        return query.ToList();
        
        
    }

    private IQueryable<AtmMachineResponseDto> GetQueryable()
    {
        var query = from atmMachine in _dbContext.AtmMachines
            join city in _dbContext.Cities on atmMachine.CityId equals city.Id
            join district in _dbContext.Districts on atmMachine.DistrictId equals district.Id
            select new AtmMachineResponseDto()
            {
                Id = atmMachine.Id,
                Name = atmMachine.Name,
                Longitude = atmMachine.Longitude,
                Latitude = atmMachine.Latitude,
                Adress = atmMachine.Adress,
                IsActive = atmMachine.IsActive,
                CityId = atmMachine.CityId,
                CityName = city.Name,
                DistrictId = atmMachine.DistrictId,
                DistrictName = district.Name,
            };
        return query;
        
    }
}