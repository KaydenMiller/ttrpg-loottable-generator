using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

public static class DescriptorErrors
{
    public static Error CannotGenerateLootTableWithoutDescriptors = Error.Failure(
        code: "descriptor-no-loot",
        description: "Cannot generate available loot when has no loot");
}