using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
using KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Repositories;

public class DescriptorRepository : IDescriptorRepository
{
    private readonly LootTableGeneratorDbContext _dbContext;

    public DescriptorRepository(LootTableGeneratorDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddDescriptorAsync(Descriptor descriptor)
    {
        await _dbContext.Descriptors.AddAsync(descriptor);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateDescriptorAsync(Descriptor descriptor)
    {
        _dbContext.Update(descriptor);
        await _dbContext.SaveChangesAsync();
    }
}