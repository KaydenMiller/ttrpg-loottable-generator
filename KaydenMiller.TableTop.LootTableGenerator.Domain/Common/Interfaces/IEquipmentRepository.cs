using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface IEquipmentRepository
{
    Task AddEquipmentAsync(Equipment equipment);
    Task UpdateEquipmentAsync(Equipment equipment);
}