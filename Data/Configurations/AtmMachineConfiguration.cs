namespace sekerbankatm.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

public class AtmMachineConfiguration : IEntityTypeConfiguration<AtmMachine>
{
    public void Configure(EntityTypeBuilder<AtmMachine> builder)
    {
        builder.HasOne(a => a.District)
            .WithMany(d => d.AtmMachines)
            .HasForeignKey(a => a.DistrictId)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
}
