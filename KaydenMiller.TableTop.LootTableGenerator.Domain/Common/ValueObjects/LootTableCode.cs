using System.Text.RegularExpressions;
using ErrorOr;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

public class LootTableCode : ValueObject
{
    public string Value { get; }
    public static readonly Regex KeyFormat = new(@"^(([abcdefghijklmnopqrstuvwxyz]+)\.?)*(:(([abcdefghijklmnopqrstuvwxyz]+)\.?)*)?$");

    private LootTableCode(string key)
    {
        Value = key.Throw().IfNotMatches(KeyFormat);
    }

    public static ErrorOr<LootTableCode> Create(string key)
    {
        var isMatch = KeyFormat.IsMatch(key);

        if (!isMatch)
        {
            return LootTableCodeErrors.InvalidKeyFormatDoesntMatchRegex;
        }

        return new LootTableCode(key);
    }

    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}