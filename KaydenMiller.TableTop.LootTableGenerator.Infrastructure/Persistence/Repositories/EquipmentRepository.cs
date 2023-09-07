using ErrorOr;
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
    
    public async Task<ErrorOr<Success>> AddEquipmentAsync(Equipment equipment)
    {
        try
        {
            await _dbContext.Equipment.AddAsync(equipment);
            await _dbContext.SaveChangesAsync();
            return new Success();
        }
        catch (Exception)
        {
            return Error.Unexpected("add-equipment-unknown", "An unknown error occured when adding equipment");
        }
    }

    public IQueryable<Equipment> ReadEquipment()
    {
        return _dbContext.Equipment.AsQueryable();
    }

    public async Task<ErrorOr<Success>> UpdateEquipmentAsync(Equipment equipment)
    {
        try
        {
            _dbContext.Update(equipment);
            await _dbContext.SaveChangesAsync();
            return new Success();
        }
        catch (Exception)
        {
            return Error.Unexpected("update-equipment-unexpected", "An unknown error occured when updating equipment");
        }
    }
}