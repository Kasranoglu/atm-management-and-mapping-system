using sekerbankatm.Data.Configurations;

namespace sekerbankatm.Data;
using Microsoft.EntityFrameworkCore;
using Entities;

public class SekerBankAtmDbContext : DbContext
{
    public SekerBankAtmDbContext(DbContextOptions<SekerBankAtmDbContext> options)
        : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }  // City tablosu
    public DbSet<AtmMachine> AtmMachines { get; set; }  // AtmMachine tablosu
    public DbSet<District> Districts { get; set; }  // District tablosu


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AtmMachineConfiguration());
        modelBuilder.ApplyConfiguration(new DistrictConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}