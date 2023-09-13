using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class ModifierIdConverter : ValueConverter<ModifierId, string>
{
    public ModifierIdConverter()
        : base(v => v.Value.ToString(),
            v => (ModifierId)Guid.Parse(v))
    {
    } 
}

public class ModifierIdComparer : ValueComparer<ModifierId>
{
    public ModifierIdComparer()
        : base((v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode(),
            v1 => v1)
    {
    }
}