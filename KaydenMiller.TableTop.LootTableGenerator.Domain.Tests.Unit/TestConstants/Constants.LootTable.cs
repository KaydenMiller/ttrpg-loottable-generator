using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestConstants;

public static partial class Constants
{
    public static class LootTable
    {
        public static readonly Guid Id = Guid.NewGuid();
        public static readonly List<Guid> DescriptorIds = new()
        {
            Guid.NewGuid(),
        };
        public static readonly List<Guid> ModifierIds = new()
        {
            Guid.NewGuid(),
        };
    }
}