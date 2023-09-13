using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class LootIdConverter : ValueConverter<LootId, string>
{
    public LootIdConverter() : base(
        v => v.Value.ToString(),
        v => (LootId)Guid.Parse(v)) {}
}

public class LootIdComparer : ValueComparer<LootId>
{
    public LootIdComparer()
        : base(
            (v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode())
    {
        
    }
}