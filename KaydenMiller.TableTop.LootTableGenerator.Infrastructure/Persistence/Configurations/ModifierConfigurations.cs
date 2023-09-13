using KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Configurations;

public class ModifierConfigurations : IEntityTypeConfiguration<Modifier>
{
    public void Configure(EntityTypeBuilder<Modifier> builder)
    {
        builder.Property(m => m.Id)
           .HasGuidConverter();
        
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Id)
           .ValueGeneratedNever();

        builder.Property<string>("_name")
           .HasColumnName("Name");
        builder.Property<int>("_minQuantityModifier")
           .HasColumnName("MinQuantityModifier");
        builder.Property<int>("_maxQuantityModifier")
          .HasColumnName("MaxQuantityModifier");
        builder.Property<float>("_quantityMultiplier")
          .HasColumnName("QuantityMultiplier");
    }
}