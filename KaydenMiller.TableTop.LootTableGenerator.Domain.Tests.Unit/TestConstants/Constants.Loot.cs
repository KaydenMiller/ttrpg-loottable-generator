using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestConstants;

public static partial class Constants
{
    public static class Loot
    {
        public static readonly Guid Id = Guid.NewGuid();
        public static readonly string Name = "Elven";
        public static readonly Percentage Rarity = new(0.5f);
        public static readonly int MinQuantity = 0;
        public static readonly int MaxQuantity = 1;
        public static readonly List<string> AssignedTags = new() { "general", "simple" };
        public static readonly Guid EquipmentId = Guid.NewGuid(); 
    }
}