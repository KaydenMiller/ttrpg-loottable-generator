namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class Identifier<T> : ValueObject
{
    public T Value { get; private set; }
    
    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }

    public Identifier(T value)
    {
        Value = value;
    }
}