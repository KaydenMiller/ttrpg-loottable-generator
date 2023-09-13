using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Converters.IdConverters;

public class DescriptorIdConverter : ValueConverter<DescriptorId, string>
{
    public DescriptorIdConverter() : base(
            v => v.Value.ToString(),
            v => (DescriptorId)Guid.Parse(v)) {}
}

public class DescriptorIdComparer : ValueComparer<DescriptorId>
{
    public DescriptorIdComparer()
        : base((v1, v2) => v1!.Equals(v2),
            v1 => v1.GetHashCode(),
            v1 => v1) {}
}