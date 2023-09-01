using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class EquipmentConfigurations : IEntityTypeConfiguration<Equipment>
{
    public void Configure(EntityTypeBuilder<Equipment> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
           .ValueGeneratedNever();

        builder.Property(a => a.Code);
        builder.Property(a => a.Name);
    }
}