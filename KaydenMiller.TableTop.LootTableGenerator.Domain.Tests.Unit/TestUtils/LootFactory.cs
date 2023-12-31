using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestUtils;

public static class LootFactory
{
    public static ErrorOr<Loot> CreateLoot(
        EquipmentId? equipmentId = null,
        LootId? id = null,
        string? name = null,
        Percentage? rarity = null,
        int? minQuantity = null,
        int? maxQuantity = null,
        IEnumerable<string>? assignedTags = null)
    {
        return Loot.Create(
            equipmentId ?? TestConstants.Constants.Loot.EquipmentId, 
            name ?? TestConstants.Constants.Loot.Name,
            rarity ?? TestConstants.Constants.Loot.Rarity,
            minQuantity ?? TestConstants.Constants.Loot.MinQuantity,
            maxQuantity ?? TestConstants.Constants.Loot.MaxQuantity,
            assignedTags ?? TestConstants.Constants.Loot.AssignedTags,
            id ?? TestConstants.Constants.Loot.Id
            );
    }
}