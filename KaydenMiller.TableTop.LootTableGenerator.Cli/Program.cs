using System.CommandLine;
using System.Text.Json;
using KaydenMiller.TableTop.LootTableGenerator.Domain;

var root = new RootCommand(
    description: "Creates new loot tables or generates available loot from an existing table");

var room = new Command("room", "loot room");
var roomCreate = new Command("create", "create a new room containing possible loot");
room.AddCommand(roomCreate);

roomCreate.SetHandler(() =>
{
    var room = new List<Room>()
    {
        new Room()
        {
            Id = "elven",
            Name = "Eleven",
            AvailableLoot = new[]
            {
                new Loot()
                {
                    Id = "sword",
                    Name = "Sword",
                    DifficultyClass = 15,
                    MaxQuantity = 1,
                    MinQuantity = 0
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
                    Id = "hammer",
                    Name = "Hammer",
                    MaxQuantity = 2,
                    MinQuantity = 1
                },
                new Loot()
                {
                    Id = "box-nails",
                    Name = "Nails",
                    MaxQuantity = 5,
                    MinQuantity = 1
                },
                new Loot()
                {
                    Id = "wood-planks",
                    Name = "Wood Planks",
                    MaxQuantity = 5,
                    MinQuantity = 0,
                }
            }
        }
    };

    var json = JsonSerializer.Serialize(room, new JsonSerializerOptions(JsonSerializerOptions.Default)
    {
        WriteIndented = true
    });
    File.WriteAllText("./rooms.json", json);
});

var loot = new Command("loot", "loot item");
var lootCreate = new Command("create", "create a new loot item that can be used");
loot.AddCommand(lootCreate);

var modifier = new Command("modifier", "loot room modifier");
var modifierCreate = new Command("create", "creates a new modifier that can be used");
modifier.AddCommand(modifierCreate);

var table = new Command("table", "loot table");
var tableRead = new Command("read", "shows all possible loot from a given table");
var tableCreate = new Command("create", "create new loot table");
var tableLoot = new Command("loot", "loots a room based on a given table");
table.AddCommand(tableRead);
table.AddCommand(tableCreate);
table.AddCommand(tableLoot);

root.AddCommand(room);

return await root.InvokeAsync(args);
