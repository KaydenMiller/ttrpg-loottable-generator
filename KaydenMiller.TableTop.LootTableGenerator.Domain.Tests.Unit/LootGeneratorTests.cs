using FluentAssertions;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit;

public class LootGeneratorTests
{
    [Fact]
    public void GivenValidRoomKey_WhenRoomContainsLoot_LootIsReturned()
    {
        var sut = new Generator();

        var keyResult = RoomKey.Create("elven");

        if (keyResult.IsError)
        {
            Assert.Fail(keyResult.FirstError.Description);
        }

        var loot = sut.Loot(keyResult.Value);

        loot.Should().BeEquivalentTo(new[]
        {
            new Loot() { Id = "food", Name = "Food", DifficultyClass = 10, MaxQuantity = 10, MinQuantity = 0 },
            new Loot() { Id = "weapon", Name = "Sword", DifficultyClass = 10, MaxQuantity = 1, MinQuantity = 0 },
        });
    }
    
    [Fact]
    public void GivenValidRoomKey_WhenRoomDifficultyIsModified_ModifiedLootIsReturned()
    {
        var sut = new Generator();

        var keyResult = RoomKey.Create("elven:ruin");

        if (keyResult.IsError)
        {
            Assert.Fail(keyResult.FirstError.Description);
        }

        var loot = sut.Loot(keyResult.Value);

        loot.Should().BeEquivalentTo(new[]
        {
            new Loot() { Id = "food", Name = "Food", DifficultyClass = 15, MaxQuantity = 10, MinQuantity = 0 },
            new Loot() { Id = "weapon", Name = "Sword", DifficultyClass = 15, MaxQuantity = 1, MinQuantity = 0 },
        });
    }
    
    [Fact]
    public void GivenValidRoomKey_WhenRoomMaxQuantityIsModified_ModifiedLootIsReturned()
    {
        var sut = new Generator();

        var keyResult = RoomKey.Create("elven:abundant");

        if (keyResult.IsError)
        {
            Assert.Fail(keyResult.FirstError.Description);
        }

        var loot = sut.Loot(keyResult.Value);

        loot.Should().BeEquivalentTo(new[]
        {
            new Loot() { Id = "food", Name = "Food", DifficultyClass = 10, MaxQuantity = 12, MinQuantity = 0 },
            new Loot() { Id = "weapon", Name = "Sword", DifficultyClass = 10, MaxQuantity = 3, MinQuantity = 0 },
        });
    }
}