namespace sekerbankatm.Data.Entities;

public class District
{
    public int Id {get;set;}
    public string Name {get;set;}
    public int CityId {get;set;}
    
    public virtual City City {get;set;}
    public ICollection<AtmMachine> AtmMachines {get;set;}
}