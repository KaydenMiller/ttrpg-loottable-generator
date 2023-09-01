using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.ValueObjects;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain;

// public class Generator : ILootable
// {
//     public IEnumerable<Loot> Loot(LootTableCode key)
//     {
//         var stages = RoomKeyDecoder.Decode(key).ToList();
//         var rooms = stages
//            .Where(stage => stage.IsModifier == false)
//            .SelectMany(stage => Rooms.Where(room => room.Id == stage.Value));
//         var modifiers = stages
//            .Where(stage => stage.IsModifier)
//            .SelectMany(stage => Modifiers.Where(modifier => modifier.Id == stage.Value));
//
//         var availableLoot = rooms
//            .GroupBy(x => x.Id)
//            .SelectMany(x => x.SelectMany(y => y.AvailableLoot))
//            .ToList();
//         var selectedModifiers = modifiers
//            .GroupBy(x => x.Id)
//            .SelectMany(x => x)
//            .ToList();
//
//         var modifiedLoot = availableLoot.ToList();
//
//         foreach (var loot in modifiedLoot)
//         {
//             foreach (var modifier in selectedModifiers)
//             {
//                 loot.DifficultyClass += modifier.DifficultyClassModifier;
//                 loot.DifficultyClass = (int)MathF.Ceiling(loot.DifficultyClass * modifier.DifficultyClassMultiplier);
//                 
//                 loot.MinQuantity += modifier.MinQuantityModifier;
//                 loot.MaxQuantity += modifier.MaxQuantityModifier;
//                 loot.MinQuantity *= (int)MathF.Ceiling(loot.MinQuantity * modifier.QuantityMultiplier);
//                 loot.MaxQuantity *= (int)MathF.Ceiling(loot.MaxQuantity * modifier.QuantityMultiplier);
//             }  
//         }
//
//         return modifiedLoot;
//     }
// }