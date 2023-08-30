namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public static class Extensions
{
    public static List<T> GetRange<T>(this List<T> list, Range range)
    {
        var (start, length) = range.GetOffsetAndLength(list.Count);
        return list.GetRange(start, length);
    }
}