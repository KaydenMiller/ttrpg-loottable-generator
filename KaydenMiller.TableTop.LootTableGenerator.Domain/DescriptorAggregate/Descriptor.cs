using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public class Descriptor : AggregateRoot
{
    public string Name { get; }
    
    private readonly HashSet<Guid> _availableLootIds = new();
    private readonly HashSet<Guid> _modifierIds = new();

    private Descriptor()
    {
    }

    public Descriptor(
        string name,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        Name = name;
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

    public List<Guid> GetAvailableLootIds()
    {
        return _availableLootIds.ToList();
    }
}