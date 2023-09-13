namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class LootTableId : GuidIdentifier
{
    public LootTableId(Guid value) : base(value)
    {
    }

    public static explicit operator LootTableId(Guid id)
    {
        return new LootTableId(id);
    }
}