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
    
    public async Task CreateLoot(Loot loot)
    {
        await _dbContext.Loot.AddAsync(loot);
        await _dbContext.SaveChangesAsync();
    }

    public Task UpdateLoot(Loot loot)
    {
        throw new NotImplementedException();
    }
}