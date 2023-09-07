using ErrorOr;
using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface IEquipmentRepository
{
    Task<ErrorOr<Success>> AddEquipmentAsync(Equipment equipment);
    IQueryable<Equipment> ReadEquipment();
    Task<ErrorOr<Success>> UpdateEquipmentAsync(Equipment equipment);
}