using System.Linq.Expressions;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;

public class PercentageConverter : ValueConverter<Percentage, float>
{
    public PercentageConverter(ConverterMappingHints? mappingHints = null) :
        base(
            v => v.Value,
            v => Percentage.FromFloat(v).Value)
    {
    }
}

public class PercentageComparer : ValueComparer<Percentage>
{
    public PercentageComparer() : base(
        (t1, t2) => t1!.Equals(t2!),
        t => t.GetHashCode(),
        t => t)
    {
    }
}