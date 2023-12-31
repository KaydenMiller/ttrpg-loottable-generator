﻿using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
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

    public IQueryable<Descriptor> ReadDescriptors()
    {
        return _dbContext.Descriptors.AsQueryable();
    }

    public async Task<Descriptor> ReadDescriptorAsync(Guid descriptorId)
    {
        var descriptor = await _dbContext.Descriptors.FindAsync(descriptorId);
        if (descriptor is null) throw new Exception("Not found descriptor");
        return descriptor;
    }
}