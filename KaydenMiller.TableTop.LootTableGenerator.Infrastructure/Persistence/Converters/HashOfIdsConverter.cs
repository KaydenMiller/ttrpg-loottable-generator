using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters;

public class HashOfIdsConverter : ValueConverter<HashSet<GuidIdentifier>, string>
{
    public HashOfIdsConverter(ConverterMappingHints? mappingHints = null)
        : base(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => (GuidIdentifier)Guid.Parse(x)).ToHashSet(),
            mappingHints)
    {
    }
}

public class HashOfIdsComparer : ValueComparer<HashSet<GuidIdentifier>>
{
    public HashOfIdsComparer() : base(
        (t1, t2) => t1!.SequenceEqual(t2!),
        t => t.Select(x => x!.GetHashCode()).Aggregate((x, y) => x ^ y),
        t => t)
    {
    }
}