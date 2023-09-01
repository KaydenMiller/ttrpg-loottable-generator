using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public static class RoomKeyDecoder
{
    public static IEnumerable<KeyStage> Decode(LootTableCode lootTableCode)
    {
        var groups = LootTableCode.KeyFormat.Match(lootTableCode.Value);
        var roomGroup = groups.Groups.Values.ToList()[2];
        var modifierGroup = groups.Groups.Values.ToList()[5];

        var rooms = roomGroup.Captures.Select(x => new KeyStage(x.Value, false));
        var modifiers = modifierGroup.Captures.Select(x => new KeyStage(x.Value, true));
        return rooms.Concat(modifiers);
    }
}