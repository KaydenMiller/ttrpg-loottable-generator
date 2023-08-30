namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class Generator : ILootable
{
    public IEnumerable<Room> Rooms = new[]
    {
        new Room()
        {
            Id = "elven",
            Name = "Elven",
            AvailableLoot = new []
            {
                new Loot()
                {
                    Id = "food",
                    Name = "Food",
                    MaxQuantity = 10
                },
                new Loot()
                {
                    Id = "weapon",
                    Name = "Sword",
                }
            }
        },
        new Room()
        {
            Id = "workshop",
            Name = "Workshop",
            AvailableLoot = new []
            {
                new Loot()
                {
                    Id = "hand-saw",
                    Name = "Hand Saw",
                },
                new Loot()
                {
                    Id = "wood",
                    Name = "Carpenters Wood",
                    MaxQuantity = 10
                }
            }
        },
        new Room()
        {
            Id = "lab",
            Name = "Lab",
            AvailableLoot = new []
            {
                new Loot()
                {
                    Id = "alchemist-kit",
                    Name = "Alchemist's Kit",
                }
            }
        }
    };

    public IEnumerable<Modifier> Modifiers = new[]
    {
        new Modifier()
        {
            Id = "ruin",
            Name = "Ruin",
            MaxQuantityModifier = 0,
            DifficultyClassModifier = 5
        },
        new Modifier()
        {
            Id = "abundant",
            Name = "Abundant",
            MaxQuantityModifier = 2,
            DifficultyClassModifier = 0
        }
    };
    
    
    public IEnumerable<Loot> Loot(RoomKey key)
    {
        var stages = RoomKeyDecoder.Decode(key).ToList();
        var rooms = stages
           .Where(stage => stage.IsModifier == false)
           .SelectMany(stage => Rooms.Where(room => room.Id == stage.Value));
        var modifiers = stages
           .Where(stage => stage.IsModifier)
           .SelectMany(stage => Modifiers.Where(modifier => modifier.Id == stage.Value));

        var availableLoot = rooms
           .GroupBy(x => x.Id)
           .SelectMany(x => x.SelectMany(y => y.AvailableLoot))
           .ToList();
        var selectedModifiers = modifiers
           .GroupBy(x => x.Id)
           .SelectMany(x => x)
           .ToList();

        var modifiedLoot = availableLoot.ToList();

        foreach (var loot in modifiedLoot)
        {
            foreach (var modifier in selectedModifiers)
            {
                loot.DifficultyClass += modifier.DifficultyClassModifier;
                loot.MinQuantity += modifier.MinQuantityModifier;
                loot.MaxQuantity += modifier.MaxQuantityModifier;
            }  
        }

        return modifiedLoot;
    }
}