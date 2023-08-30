namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

public class KeyStage
{
    public string Value { get; }
    public bool IsModifier { get; }

    public KeyStage(string stage, bool isModifier)
    {
        Value = stage;
        IsModifier = isModifier;
    }
}