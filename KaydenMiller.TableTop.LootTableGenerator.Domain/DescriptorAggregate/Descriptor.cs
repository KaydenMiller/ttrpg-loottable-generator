using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public class Descriptor : Entity 
{
    private readonly string _code;
    private readonly string _name;
    private readonly IEnumerable<Guid> _availableLootIds;
    private readonly IEnumerable<Guid> _modifierIds;

    public Descriptor(Guid id) : base(id)
    {
    }
}