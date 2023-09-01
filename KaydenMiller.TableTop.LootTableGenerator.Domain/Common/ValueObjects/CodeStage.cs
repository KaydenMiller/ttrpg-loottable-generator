namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

public class CodeStage : ValueObject
{
    public string Value { get; }
    public bool IsModifier { get; }

    public CodeStage(string stage, bool isModifier)
    {
        Value = stage;
        IsModifier = isModifier;
    }

    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
        yield return IsModifier;
    }
}