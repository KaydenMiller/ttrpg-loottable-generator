using ErrorOr;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

public class Percentage : ValueObject
{
    public float Value { get; init; }

    public Percentage(float value)
    {
        Value = value.Throw().IfLessThan(0).IfGreaterThan(1);
    }

    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }

    public static ErrorOr<Percentage> FromFloat(float value)
    {
        return value switch
        {
            < 0 => PercentageErrors.PercentFloatLowerBoundExceeded,
            > 1 => PercentageErrors.PercentFloatUpperBoundExceeded,
            _ => new Percentage(value)
        };
    }

    public static ErrorOr<Percentage> FromInt(int value)
    {
        return value switch
        {
            < 0 => PercentageErrors.PercentIntLowerBoundExceeded,
            > 100 => PercentageErrors.PercentIntUpperBoundExceeded,
            _ => new Percentage(value / 100.0f)
        };
    }
}