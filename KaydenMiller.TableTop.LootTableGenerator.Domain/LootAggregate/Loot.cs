using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

public class Loot : AggregateRoot
{
    private readonly Guid _equipmentId;
    private readonly string _name;
    private readonly Percentage _rarity;
    private readonly int _maxQuantity;
    private readonly int _minQuantity;
   
    private Loot() {}
    public Loot(
        Guid equipmentId,
        string name,
        Percentage rarity,
        int maxQuantity,
        int minQuantity,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        _equipmentId = equipmentId;
        _name = name;
        _rarity = rarity;
        _minQuantity = minQuantity.Throw()
           .IfLessThan(0)
           .IfGreaterThan(maxQuantity);
        _maxQuantity = maxQuantity;
    }

    public static ErrorOr<Loot> Create(
        Guid equipmentId,
        string name,
        Percentage rarity,
        int minQuantity,
        int maxQuantity,
        Guid? id)
    {
        if (minQuantity < 0)
        {
            return LootErrors.MinQuantityCantBeLessThan0;
        }

        if (minQuantity > maxQuantity)
        {
            return LootErrors.MinQuantityExceedsMaxQuantity;
        }

        return new Loot(
            equipmentId,
            name,
            rarity,
            maxQuantity,
            minQuantity,
            id);
    }
}