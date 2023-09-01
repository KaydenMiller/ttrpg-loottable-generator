using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

public static class LootErrors
{
    public static Error MinQuantityCantBeLessThan0 = Error.Validation(
        code: "min-quantity-less-than-zero",
        description: "The minimum quantity cannot be less than 0");

    public static Error MinQuantityExceedsMaxQuantity = Error.Validation(
        code: "min-quantity-exceeds-max-quantity",
        description: "The minimum quantity cannot be greater than the maximum quantity");
}