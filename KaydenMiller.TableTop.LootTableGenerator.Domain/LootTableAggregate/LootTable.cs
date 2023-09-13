using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.LootTableAggregate;

public class LootTable : AggregateRoot
{
    private readonly List<DescriptorId> _descriptorIds;
    private readonly List<ModifierId> _modifierIds;
    
    private LootTable() {}
    public LootTable(
        IEnumerable<DescriptorId> descriptorIds,
        IEnumerable<ModifierId> modifierIds,
        LootTableId? id = null) : base(id ?? Guid.NewGuid())
    {
        _descriptorIds = descriptorIds.ToList();
        _modifierIds = modifierIds.ToList();
    }

    public static ErrorOr<LootTable> Create(
        IEnumerable<DescriptorId> descriptorIds,
        IEnumerable<ModifierId> modifierIds,
        LootTableId? id = null)
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