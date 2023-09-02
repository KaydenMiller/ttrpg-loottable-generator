using KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class DescriptorConfigurations : IEntityTypeConfiguration<Descriptor>
{
    public void Configure(EntityTypeBuilder<Descriptor> builder)
    {
        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
           .ValueGeneratedNever();

        builder.Property(d => d.Name)
           .HasColumnName("Name");
        builder.Property<HashSet<Guid>>("_availableLootIds")
           .HasColumnName("AvailableLootIds")
           .HasHashOfIdsConverter();
        builder.Property<HashSet<Guid>>("_modifierIds")
           .HasColumnName("ModifierIds")
           .HasHashOfIdsConverter();
    }
}