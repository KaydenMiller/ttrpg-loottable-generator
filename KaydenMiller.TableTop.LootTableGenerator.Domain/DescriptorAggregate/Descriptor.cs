using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public class Descriptor : Entity
{
    private readonly List<Guid> _availableLootIds = new();
    private readonly List<Guid> _modifierIds = new();

    public Descriptor(Guid? id = null) : base(id ?? Guid.NewGuid())
    {
    }
}