using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

public class Equipment : AggregateRoot
{
    public string Code { get; }
    public string Name { get; }

    private Equipment()
    {
    }

    public Equipment(
        string code,
        string name,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        Code = code;
        Name = name;
    }
}