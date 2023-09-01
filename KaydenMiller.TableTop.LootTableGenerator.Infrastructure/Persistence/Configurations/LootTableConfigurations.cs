using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class LootTableConfigurations : IEntityTypeConfiguration<LootTable>
{
    public void Configure(EntityTypeBuilder<LootTable> builder)
    {
        builder.HasKey(lt => lt.Id);

        builder.Property(lt => lt.Id)
           .ValueGeneratedNever();

        builder.Property<List<Guid>>("_descriptorIds")
           .HasColumnName("DescriptorIds")
           .HasListOfIdsConverter();
        builder.Property<List<Guid>>("_modifierIds")
           .HasColumnName("ModifierIds")
           .HasListOfIdsConverter();
    }
}