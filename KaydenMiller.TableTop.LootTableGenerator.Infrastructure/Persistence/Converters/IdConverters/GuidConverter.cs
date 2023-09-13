using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class GuidConverter : ValueConverter<Guid, string>
{
    public GuidConverter() : base(
        v => v.ToString(),
        v => Guid.Parse(v))
    {
    }
}

public class GuidComparer : ValueComparer<Guid>
{
    public GuidComparer()
        : base((v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode(),
            v1 => v1)
    {
    }
}