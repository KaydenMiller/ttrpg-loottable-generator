using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class EquipmentIdConverter : ValueConverter<EquipmentId, string>
{
    public EquipmentIdConverter() 
        : base(
            v => v.Value.ToString(),
            v => (EquipmentId)Guid.Parse(v)) {}
}

public class EquipmentIdComparer : ValueComparer<EquipmentId>
{
    public EquipmentIdComparer()
        : base(
            (v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode(),
            v1 => v1)
    {
    }
}