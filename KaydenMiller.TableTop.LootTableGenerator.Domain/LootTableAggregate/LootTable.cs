using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

public class LootTable : AggregateRoot
{
    private readonly List<Guid> _descriptorIds;
    private readonly List<Guid> _modifierIds;
    
    private LootTable() {}
    public LootTable(
        IEnumerable<Guid> descriptorIds,
        IEnumerable<Guid> modifierIds,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        _descriptorIds = descriptorIds.ToList();
        _modifierIds = modifierIds.ToList();
    }

    public static ErrorOr<LootTable> Create(
        IEnumerable<Guid> descriptorIds,
        IEnumerable<Guid> modifierIds,
        Guid? id = null)
    {
        return new LootTable(
            descriptorIds,
            modifierIds,
            id);
    }

    public ErrorOr<Success> Generate()
    {
        if (_descriptorIds.Count == 0)
        {
            return LootTableErrors.CannotGenerateLootTableWithoutDescriptors;
        }

        return new Success();
    }
}