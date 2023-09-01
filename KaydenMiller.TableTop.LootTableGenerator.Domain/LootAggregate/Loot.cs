using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

public class Loot : AggregateRoot 
{
    private readonly string _name;
    private readonly Percentage _rarity;
    private readonly int _maxQuantity;
    private readonly int _minQuantity;
    
    public Loot(
        string name,
        Percentage rarity,
        int maxQuantity,
        int minQuantity,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        _name = name;
        _rarity = rarity;
        _minQuantity = minQuantity.Throw()
           .IfLessThan(0)
           .IfGreaterThan(maxQuantity);
        _maxQuantity = maxQuantity;
    }

    public static ErrorOr<Loot> Create(
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
            name,
            rarity,
            maxQuantity,
            minQuantity,
            id);
    }
}