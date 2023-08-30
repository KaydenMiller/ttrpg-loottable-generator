namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class Room
{
    public string Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Loot> AvailableLoot { get; set; }
}

public class Loot
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int DifficultyClass { get; set; } = 10;
    public int MaxQuantity { get; set; } = 1;
    public int MinQuantity { get; set; } = 0;

    public override string ToString()
    {
        return $"{Name}: DC{DifficultyClass} @ {MinQuantity}-{MaxQuantity}";
    }
}

public class Modifier
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int DifficultyClassModifier { get; set; } = 0;
    public float DifficultyClassMultiplier { get; set; } = 1;
    public int MinQuantityModifier { get; set; } = 0;
    public int MaxQuantityModifier { get; set; } = 0;
    public float QuantityMultiplier { get; set; } = 1;
}