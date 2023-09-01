using KaydenMiller.TableTop.LootTableGenerator.Domain.Common;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class Modifier : Entity
{
    private readonly string _code;
    private readonly string _name;
    private readonly int _difficultyClassModifier = 0;
    private readonly float _difficultyClassMultiplier = 1f;
    private readonly int _minQuantityModifier = 0;
    private readonly int _maxQuantityModifier = 0;
    private readonly float _quantityMultiplier = 1f;
    
    public Modifier(Guid id) : base(id)
    {
    }
}