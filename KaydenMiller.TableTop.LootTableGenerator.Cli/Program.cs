using KaydenMiller.TableTop.LootTableGenerator.Domain;

var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: Invalid input, was empty");
    Environment.Exit(1);
}

var keyResult = RoomKey.Create(input);

if (keyResult.IsError)
{
    Console.WriteLine($"Error: {keyResult.FirstError.Description}");
    Environment.Exit(1);
}

var lootGen = new Generator();

var loot = lootGen.Loot(keyResult.Value);

Console.WriteLine(input);
Console.WriteLine("-----------------------");
foreach (var item in loot)
{
    Console.WriteLine(item);
}
