using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface ILootRepository
{
    public Task CreateLoot(Loot loot);
    public Task UpdateLoot(Loot loot);
}