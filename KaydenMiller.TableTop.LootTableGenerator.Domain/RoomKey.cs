using System.Text.RegularExpressions;
using ErrorOr;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class RoomKey
{
    public string Value { get; }
    public static readonly Regex KeyFormat = new(@"^(([abcdefghijklmnopqrstuvwxyz]+)\.?)*(:(([abcdefghijklmnopqrstuvwxyz]+)\.?)*)?$");

    private RoomKey(string key)
    {
        Value = key;
    }

    public static ErrorOr<RoomKey> Create(string key)
    {
        var isMatch = KeyFormat.IsMatch(key);

        if (!isMatch)
        {
            return Error.Validation("key-invalid-format", "Invalid format for the room key");
        }

        return new RoomKey(key);
    }
}