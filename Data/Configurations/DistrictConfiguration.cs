namespace sekerbankatm.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities;

public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
  public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.HasOne(d => d.City)
            .WithMany(c => c.Districts)
            .HasForeignKey(d => d.CityId)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
  

}