namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class LootId : GuidIdentifier
{
    public LootId(Guid value) : base(value)
    {
    }

    public static explicit operator LootId(Guid id)
    {
        return new LootId(id);
    }
}