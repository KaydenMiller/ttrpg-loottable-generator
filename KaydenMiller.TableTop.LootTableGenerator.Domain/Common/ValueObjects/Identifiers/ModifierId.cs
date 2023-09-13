namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class ModifierId : GuidIdentifier
{
    public ModifierId(Guid value) : base(value)
    {
    }

    public static explicit operator ModifierId(Guid id)
    {
        return new ModifierId(id);
    }
}