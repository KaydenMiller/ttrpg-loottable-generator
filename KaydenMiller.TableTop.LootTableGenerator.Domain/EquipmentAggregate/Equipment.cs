using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;

public class Equipment : AggregateRoot
{
    private readonly string _code;
    private readonly string _name;
    
    public Equipment(
        string code,
        string name,
        Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        _code = code;
        _name = name;
    }
}