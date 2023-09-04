using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTob.LootTableGenerator.Site.Extensions;

public static class DomainExtensions
{
    public static string AsPercentString(this Percentage percentage)
    {
        return $"{percentage.Value * 100}%";
    }
}