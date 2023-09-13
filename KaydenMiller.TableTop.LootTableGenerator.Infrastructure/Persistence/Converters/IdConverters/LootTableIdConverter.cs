using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class LootTableIdConverter : ValueConverter<LootTableId, string>
{
    public LootTableIdConverter()
        : base(
            v => v.Value.ToString(),
            v => (LootTableId)Guid.Parse(v))
    {
    }
}

public class LootTableIdComparer : ValueComparer<LootTableId>
{
    public LootTableIdComparer()
        : base((v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode(),
            v1 => v1)
    {
    }
}