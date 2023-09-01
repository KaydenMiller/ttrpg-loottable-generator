using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

public static class PercentageErrors
{
    public static readonly Error PercentFloatLowerBoundExceeded = Error.Validation(
        code: "percent-float-lower-bound",
        description: "Lower bound of percentage is 0");

    public static readonly Error PercentFloatUpperBoundExceeded = Error.Validation(
        code: "percent-float-upper-bound",
        description: "Upper bound of percentage is 1");

    public static readonly Error PercentIntLowerBoundExceeded = Error.Validation(
        code: "percent-int-lower-bound",
        description: "Lower bound of percentage is 0");

    public static readonly Error PercentIntUpperBoundExceeded = Error.Validation(
        code: "percent-int-upper-bound",
        description: "Upper bound of percentage is 100");
}