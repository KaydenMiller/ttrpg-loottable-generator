using System.Text.Json.Serialization;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class Room
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("availableLoot")]
    public IEnumerable<Loot> AvailableLoot { get; set; }
}

public class Loot
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("difficultyClass")]
    public int DifficultyClass { get; set; } = 10;
    
    [JsonPropertyName("maxQuantity")]
    public int MaxQuantity { get; set; } = 1;
    
    [JsonPropertyName("minQuantity")]
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