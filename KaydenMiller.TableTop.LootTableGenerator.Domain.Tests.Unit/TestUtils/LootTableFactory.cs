using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootTableAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestUtils;

public class LootTableFactory
{
    public ErrorOr<LootTable> Create(
        LootTableId? id = null,
        IEnumerable<DescriptorId>? descriptorIds = null,
        IEnumerable<ModifierId>? modifierIds = null)
    {
        return LootTable.Create(
            descriptorIds ?? new List<DescriptorId>(),
            modifierIds ?? new List<ModifierId>(),
            id);
    }
}