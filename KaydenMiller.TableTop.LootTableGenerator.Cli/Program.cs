using KaydenMiller.TableTop.LootTableGenerator.Domain;

var input = "elven.workshop:abundant.ruin";
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
