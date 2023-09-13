namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class EquipmentId : GuidIdentifier
{
    public EquipmentId(Guid value) : base(value)
    {
    }

    public static explicit operator EquipmentId(Guid value)
    {
        return new EquipmentId(value);
    }
}