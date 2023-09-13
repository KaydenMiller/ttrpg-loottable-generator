namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class DescriptorId : GuidIdentifier
{
    public DescriptorId(Guid value) : base(value)
    {
    }

    public static explicit operator DescriptorId(Guid value)
    {
        return new DescriptorId(value);
    }
}