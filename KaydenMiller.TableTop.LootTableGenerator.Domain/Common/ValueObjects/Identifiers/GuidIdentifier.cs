using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;

public class GuidIdentifier : Identifier<Guid>
{
    public GuidIdentifier(Guid value) : base(value)
    {
    }

    public static ErrorOr<GuidIdentifier> Create(Guid value)
    {
        if (value == Guid.Empty)
        {
            return Error.Validation("guid-id-is-empty-guid", "A new Guid Identifier should not be an empty guid");
        }

        return new GuidIdentifier(value);
    }

    public static explicit operator GuidIdentifier(Guid value)
    {
        var result = GuidIdentifier.Create(value);

        if (result.IsError)
        {
            throw new Exception(result.FirstError.Description);
        }

        return result.Value;
    }

    public static implicit operator Guid(GuidIdentifier id)
    {
        return id.Value;
    }
}