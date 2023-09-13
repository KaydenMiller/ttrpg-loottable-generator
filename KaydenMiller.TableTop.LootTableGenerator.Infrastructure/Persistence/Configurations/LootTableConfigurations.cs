using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootTableAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class LootTableConfigurations : IEntityTypeConfiguration<LootTable>
{
    public void Configure(EntityTypeBuilder<LootTable> builder)
    {
        builder.Property(lt => lt.Id)
           .HasGuidConverter();
        
        builder.HasKey(lt => lt.Id);

        builder.Property(lt => lt.Id)
           .ValueGeneratedNever();

        builder.Property<List<DescriptorId>>("_descriptorIds")
           .HasColumnName("DescriptorIds")
           .HasColumnType("jsonb");
        builder.Property<List<ModifierId>>("_modifierIds")
           .HasColumnName("ModifierIds")
           .HasColumnType("jsonb");
    }
}