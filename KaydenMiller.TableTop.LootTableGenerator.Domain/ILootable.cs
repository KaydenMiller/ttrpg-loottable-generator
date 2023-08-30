namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public interface ILootable
{
    public IEnumerable<Loot> Loot(RoomKey key);
}