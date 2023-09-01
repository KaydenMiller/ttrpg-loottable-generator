using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestUtils;

public class LootTableFactory
{
    public ErrorOr<LootTable> Create(
        Guid? id = null,
        IEnumerable<Guid>? descriptorIds = null,
        IEnumerable<Guid>? modifierIds = null)
    {
        return LootTable.Create(
            descriptorIds ?? new List<Guid>(),
            modifierIds ?? new List<Guid>(),
            id);
    }
}