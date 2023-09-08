using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class LootConfiguration : IEntityTypeConfiguration<Loot>
{
    public void Configure(EntityTypeBuilder<Loot> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
           .ValueGeneratedNever();

        builder.Property<List<string>>("_assignedTags")
          .HasColumnName("AssignedTags")
          .HasListOfStringsConverter();
        builder.Property<Percentage>("_rarity")
          .HasColumnName("RarityPercentage")
          .HasPercentageConverter()
           .HasDefaultValue(Percentage.FromFloat(0.5f).Value);
        builder.Property<Guid>("_equipmentId")
           .HasColumnName("EquipmentId");
        builder.Property<string>("_name")
           .HasColumnName("Name");
        builder.Property<int>("_minQuantity")
          .HasColumnName("MinQuantity");
        builder.Property<int>("_maxQuantity")
          .HasColumnName("MaxQuantity");
    }
}