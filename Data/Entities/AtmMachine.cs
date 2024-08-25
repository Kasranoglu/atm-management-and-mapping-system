namespace sekerbankatm.Data.Entities;

public class AtmMachine
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Longitude {get;set;}
    public double Latitude {get;set;}
    public string  Adress {get;set;}
    public int DistrictId {get;set;}
    public int CityId {get;set;}
    public bool IsActive {get;set;}
    public virtual District District {get;set;}
    public virtual City City {get;set;}
}