using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;

public class Modifier : Entity
{
    private readonly string _name;
    private readonly int _minQuantityModifier = 0;
    private readonly int _maxQuantityModifier = 0;
    private readonly float _quantityMultiplier = 1f;
    
    public Modifier(Guid id) : base(id)
    {
    }
}