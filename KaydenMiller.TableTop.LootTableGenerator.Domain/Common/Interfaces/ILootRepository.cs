using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface ILootRepository
{
    public Task CreateLootAsync(Loot loot);
    public Task<Loot> ReadLootByIdAsync(Guid lootId);
    public IQueryable<Loot> ReadLoot();
    public Task UpdateLootAsync(Loot loot);
}