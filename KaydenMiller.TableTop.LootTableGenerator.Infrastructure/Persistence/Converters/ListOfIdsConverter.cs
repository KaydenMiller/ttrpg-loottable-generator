using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters; 

public class ListOfIdsConverter : ValueConverter<List<GuidIdentifier>, string>
{
    public ListOfIdsConverter(ConverterMappingHints? mappingHints = null)
        : base(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => (GuidIdentifier)Guid.Parse(x)).ToList(),
            mappingHints)
    {
    }
}

public class ListOfIdsComparer : ValueComparer<List<GuidIdentifier>>
{
    public ListOfIdsComparer() : base(
      (t1, t2) => t1!.SequenceEqual(t2!),
      t => t.Select(x => x!.GetHashCode()).Aggregate((x, y) => x ^ y),
      t => t)
    {
    }
}