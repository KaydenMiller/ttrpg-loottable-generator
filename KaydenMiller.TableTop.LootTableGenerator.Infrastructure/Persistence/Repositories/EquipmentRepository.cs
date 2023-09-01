using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    private readonly LootTableGeneratorDbContext _dbContext;

    public EquipmentRepository(LootTableGeneratorDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task AddEquipmentAsync(Equipment equipment)
    {
        await _dbContext.Equipment.AddAsync(equipment);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateEquipmentAsync(Equipment equipment)
    {
        _dbContext.Update(equipment);
        await _dbContext.SaveChangesAsync();
    }
}