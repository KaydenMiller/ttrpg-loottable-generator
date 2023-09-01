using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;

public static class LootTableErrors
{
    public static Error CannotGenerateLootTableWithoutDescriptors = Error.Failure(
        code: "loot-table-no-descriptor",
        description: "Cannot generate a loot table that has no descriptors");
}