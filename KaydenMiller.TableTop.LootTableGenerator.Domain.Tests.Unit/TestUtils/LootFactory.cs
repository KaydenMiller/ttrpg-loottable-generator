using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestUtils;

public static class LootFactory
{
    public static ErrorOr<Loot> CreateLoot(
        Guid? equipmentId = null,
        Guid? id = null,
        string? name = null,
        Percentage? rarity = null,
        int? minQuantity = null,
        int? maxQuantity = null)
    {
        return Loot.Create(
            equipmentId ?? TestConstants.Constants.Loot.EquipmentId, 
            name ?? TestConstants.Constants.Loot.Name,
            rarity ?? TestConstants.Constants.Loot.Rarity,
            minQuantity ?? TestConstants.Constants.Loot.MinQuantity,
            maxQuantity ?? TestConstants.Constants.Loot.MaxQuantity,
            id ?? TestConstants.Constants.Loot.Id
            );
    }
}