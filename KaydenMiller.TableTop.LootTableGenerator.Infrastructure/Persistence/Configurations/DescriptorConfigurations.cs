using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class DescriptorConfigurations : IEntityTypeConfiguration<Descriptor>
{
    public void Configure(EntityTypeBuilder<Descriptor> builder)
    {
        builder.Property(d => d.Id)
           .HasGuidConverter();
       
        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
           .ValueGeneratedNever();

        builder.Property(d => d.Name)
           .HasColumnName("Name");
        builder.Property<HashSet<LootId>>("_availableLootIds")
           .HasColumnName("AvailableLootIds")
           .HasColumnType("jsonb");
        builder.Property<HashSet<ModifierId>>("_modifierIds")
           .HasColumnName("ModifierIds")
           .HasColumnType("jsonb");
    }
}