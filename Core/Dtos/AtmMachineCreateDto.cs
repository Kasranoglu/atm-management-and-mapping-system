namespace sekerbankatm.Core.Dtos;

public class AtmMachineCreateDto
{
    public string Name {get;set;}
    public double Longitude {get;set;}
    public double Latitude {get;set;}
    public string  Adress {get;set;}
    public int DistrictId {get;set;}
    public int CityId {get;set;}
    public bool IsActive {get;set;}
}