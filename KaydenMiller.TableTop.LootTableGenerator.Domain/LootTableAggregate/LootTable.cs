using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

public class LootTable : AggregateRoot
{
    private readonly IEnumerable<Guid> _descriptorIds;
    private readonly IEnumerable<Guid> _modifierIds;
    
    public LootTable(Guid? id = null) : base(id ?? Guid.NewGuid())
    {
    }
}