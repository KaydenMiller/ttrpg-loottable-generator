using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Repositories;

public class LootRepository : ILootRepository
{
    private readonly LootTableGeneratorDbContext _dbContext;

    public LootRepository(LootTableGeneratorDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task CreateLootAsync(Loot loot)
    {
        await _dbContext.Loot.AddAsync(loot);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Loot> ReadLootByIdAsync(Guid lootId)
    {
        var response = await _dbContext.Loot.FindAsync(lootId);
        if (response is null) throw new Exception("Not found");
        return response;
    }

    public IQueryable<Loot> ReadLoot()
    {
        var response = _dbContext.Loot.AsQueryable();
        return response;
    }

    public Task UpdateLootAsync(Loot loot)
    {
        throw new NotImplementedException();
    }
}