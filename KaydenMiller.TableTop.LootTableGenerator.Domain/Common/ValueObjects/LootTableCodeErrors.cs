using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

public static class LootTableCodeErrors
{
    public static readonly Error InvalidKeyFormatDoesntMatchRegex = Error.Validation(
        code: "key-invalid-format",
        description: "Invalid format for the key it doesn't match the regex");
}