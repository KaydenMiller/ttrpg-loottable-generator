using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public class Descriptor : AggregateRoot
{
    public string Name { get; }
    
    private readonly HashSet<LootId> _availableLootIds = new();
    private readonly HashSet<ModifierId> _modifierIds = new();

    private Descriptor()
    {
    }

    public Descriptor(
        string name,
        DescriptorId? id = null) : base(id ?? Guid.NewGuid())
    {
        Name = name;
    }

    public ErrorOr<Success> AddLoot(Loot loot)
    {
        _availableLootIds.Add((LootId)loot.Id);
        return new Success();
    }

    public ErrorOr<Success> AddModifier(Modifier modifier)
    {
        _modifierIds.Add((ModifierId)modifier.Id);
        return new Success(); 
    }

    public List<LootId> GetAvailableLootIds()
    {
        return _availableLootIds.ToList();
    }
}