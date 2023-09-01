using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public class Descriptor : AggregateRoot 
{
    private readonly HashSet<Guid> _availableLootIds = new();
    private readonly HashSet<Guid> _modifierIds = new();

    private Descriptor()
    {
    }

    public Descriptor(Guid? id = null) : base(id ?? Guid.NewGuid())
    {
    }

    public ErrorOr<Success> AddLoot(Loot loot)
    {
        _availableLootIds.Add(loot.Id);
        return new Success();
    }

    public ErrorOr<Success> AddModifier(Modifier modifier)
    {
        _modifierIds.Add(modifier.Id);
        return new Success(); 
    }
}