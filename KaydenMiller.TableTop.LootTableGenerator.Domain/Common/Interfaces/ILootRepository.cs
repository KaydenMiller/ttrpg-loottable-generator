using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface ILootRepository
{
    public Task CreateLootAsync(Loot loot);
    public Task<Loot> ReadLootAsync(Guid lootId);
    public Task UpdateLootAsync(Loot loot);
}