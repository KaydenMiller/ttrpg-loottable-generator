using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters; 

public static class FluentApiExtensions
{
    public static PropertyBuilder<T> HasPercentageConverter<T>(this PropertyBuilder<T> propertyBuilder)
    {
        return propertyBuilder.HasConversion(
            new PercentageConverter(),
            new PercentageComparer());
    }

    public static PropertyBuilder<T> HasGuidConverter<T>(this PropertyBuilder<T> propertyBuilder)
    {
        return propertyBuilder.HasConversion(
            new GuidConverter(),
            new GuidComparer());
    }
}