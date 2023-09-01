using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface ILootable
{
    public IEnumerable<Loot> Loot(LootTableCode key);
}