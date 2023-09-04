using System.Diagnostics;
using Ardalis.SmartEnum;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTob.LootTableGenerator.Site.Data;

public class RarityType : SmartEnum<RarityType>
{
    public static readonly RarityType Common = new(nameof(Common), 0);
    public static readonly RarityType Uncommon = new(nameof(Uncommon), 1);
    public static readonly RarityType Rare = new(nameof(Rare), 2);
    public static readonly RarityType VeryRare = new(nameof(VeryRare), 3);
    public static readonly RarityType Legendary = new(nameof(Legendary), 4);
    
    public RarityType(string name, int value) : base(name, value)
    {
    }
}

public static class RarityTypeExtensions
{
    public static Percentage ToPercentage(this RarityType rarity)
    {
        return rarity.Name switch
        {
            nameof(RarityType.Common) => Percentage.FromInt(85).Value,
            nameof(RarityType.Uncommon) => Percentage.FromInt(65).Value,
            nameof(RarityType.Rare) => Percentage.FromInt(45).Value,
            nameof(RarityType.VeryRare) => Percentage.FromInt(25).Value,
            nameof(RarityType.Legendary) => Percentage.FromInt(5).Value,
            _ => throw new UnreachableException("Type of Rarity not recognized")
        };
    }
}