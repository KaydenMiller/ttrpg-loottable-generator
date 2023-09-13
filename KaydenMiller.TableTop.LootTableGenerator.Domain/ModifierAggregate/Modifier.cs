using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects.Identifiers;
using Throw;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;

public class Modifier : Entity
{
    private readonly string _name;
    private readonly int _minQuantityModifier;
    private readonly int _maxQuantityModifier;
    private readonly float _quantityMultiplier;
    
    private Modifier() {}
    public Modifier(
        string name,
        int minQuantityModifier,
        int maxQuantityModifier,
        float quantityMultiplier,
        ModifierId? id = null) : base(id ?? Guid.NewGuid())
    {
        _name = name;
        _minQuantityModifier = minQuantityModifier;
        _maxQuantityModifier = maxQuantityModifier;
        _quantityMultiplier = quantityMultiplier.Throw().IfLessThan(0f);
    }
}