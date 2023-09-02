using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface IEquipmentRepository
{
    Task AddEquipmentAsync(Equipment equipment);
    IQueryable<Equipment> ReadEquipment();
    Task UpdateEquipmentAsync(Equipment equipment);
}