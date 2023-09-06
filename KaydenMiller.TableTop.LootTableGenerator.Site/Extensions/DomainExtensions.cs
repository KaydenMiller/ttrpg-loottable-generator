using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTop.LootTableGenerator.Site.Extensions;

public static class DomainExtensions
{
    public static string AsPercentString(this Percentage percentage)
    {
        return $"{percentage.Value * 100}%";
    }

    public static int ToInteger(this Percentage percentage)
    {
        return (int)MathF.Floor(percentage.Value * 100.0f);
    }
}