using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

public class Loot : AggregateRoot
{
    private readonly Guid _equipmentId;
    private readonly string _name;
    private readonly Percentage _rarity;
    private readonly int _maxQuantity;
    private readonly int _minQuantity;
    
    public string Name => _name;
    /// <summary>
    /// Represents the percentage chance that something exists, when rolled for.
    /// Given a roll of 60 out of 100
    /// If the Rarity is 70 out of 100
    /// Then the roll succeeds and the item exists
    /// However, given a roll of 71 out of 100
    /// Then the roll will fail and the item does not exist
    /// </summary>
    public Percentage Rarity => _rarity;
    public int MaxQuantity => _maxQuantity;
    public int MinQuantity => _minQuantity;

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

    /// <summary>
    /// Given the possible rolls returns the count of items that do exist
    /// </summary>
    public int Roll()
    {
        // How many could exist
        var rand = new Random();
        var rollsToAttempt = rand.Next(_minQuantity, _maxQuantity + 1);

        var itemsThatExist = 0;
        
        // How many do exist
        for (var attemptedRolls = 0; attemptedRolls < rollsToAttempt; attemptedRolls++)
        {
            var diceRoll = rand.Next(1, 101); // 1 - 100

            if (_rarity.Value <= 0)
            {
                // Can't roll can't succeed
                continue;
            }

            if (_rarity.Value >= 100)
            {
                // Roll Will always succeed
                itemsThatExist++;
            }
            
            if (diceRoll <= _rarity.Value * 100)
            {
                // Example: rarity=60 dice_roll=50 then success
                itemsThatExist++;
            }
        }

        return itemsThatExist;
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