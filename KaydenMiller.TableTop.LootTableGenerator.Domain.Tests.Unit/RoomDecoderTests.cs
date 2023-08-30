using FluentAssertions;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit;

public class RoomDecoderTests
{
    [Theory]
    [InlineData("elven")]
    [InlineData("dwarven")]
    [InlineData("workshop")]
    public void GivenValidRoomKey_WhenContainingOneRoom_ShouldParse(string roomKeyValue)
    {
        // Arrange
        var result = RoomKey.Create(roomKeyValue);

        if (result.IsError)
        {
            Assert.Fail(result.FirstError.Description);
        }
        
        // Act
        var stages = RoomKeyDecoder.Decode(result.Value).ToList();

        // Assert
        stages.Should().ContainSingle();
        stages.Should().BeEquivalentTo(new [] {
            new KeyStage(roomKeyValue, false)
        });
    }
    
    [Theory]
    [InlineData("elven.workshop", "elven", "workshop")]
    [InlineData("dwarven.masonry", "dwarven", "masonry")]
    [InlineData("workshop.lab", "workshop", "lab")]
    [InlineData("elven.workshop.lab", "elven", "workshop", "lab")]
    public void GivenValidRoomKey_WhenContainingMultipleRooms_ShouldParse(string roomKeyValue, params string[] parts)
    {
        // Arrange
        var result = RoomKey.Create(roomKeyValue);

        if (result.IsError)
        {
            Assert.Fail(result.FirstError.Description);
        }
        
        // Act
        var stages = RoomKeyDecoder.Decode(result.Value).ToList();

        // Assert
        stages.Should().BeEquivalentTo(parts.Select(x => new KeyStage(x, false))); 
    }

    [Theory]
    [InlineData("elven:ruin", new[] { "elven", "ruin" }, new[] { false, true })]
    public void GivenValidRoomKey_WhenContainingRoomAndModifier_ShouldParse(string roomKeyValue, string[] parts, bool[] modifiers)
    {
        // Arrange
        var expected = parts.Zip(modifiers);
        var result = RoomKey.Create(roomKeyValue);

        if (result.IsError)
        {
            Assert.Fail(result.FirstError.Description);
        }
        
        // Act
        var stages = RoomKeyDecoder.Decode(result.Value).ToList();

        // Assert
        stages.Should().BeEquivalentTo(expected.Select(stage => new KeyStage(stage.First, stage.Second)));  
    }
    
    [Theory]
    [InlineData("elven.workshop:ruin", new[] { "elven", "workshop", "ruin" }, new[] { false, false, true })]
    public void GivenValidRoomKey_WhenContainingRoomsAndModifier_ShouldParse(string roomKeyValue, string[] parts, bool[] modifiers)
    {
        // Arrange
        var expected = parts.Zip(modifiers);
        var result = RoomKey.Create(roomKeyValue);

        if (result.IsError)
        {
            Assert.Fail(result.FirstError.Description);
        }
        
        // Act
        var stages = RoomKeyDecoder.Decode(result.Value).ToList();

        // Assert
        stages.Should().BeEquivalentTo(expected.Select(stage => new KeyStage(stage.First, stage.Second)));  
    }
    
    [Theory]
    [InlineData("elven.workshop:ruin.abundant", new[] { "elven", "workshop", "ruin", "abundant" }, new[] { false, false, true, true })]
    public void GivenValidRoomKey_WhenContainingRoomsAndModifiers_ShouldParse(string roomKeyValue, string[] parts, bool[] modifiers)
    {
        // Arrange
        var expected = parts.Zip(modifiers);
        var result = RoomKey.Create(roomKeyValue);

        if (result.IsError)
        {
            Assert.Fail(result.FirstError.Description);
        }
        
        // Act
        var stages = RoomKeyDecoder.Decode(result.Value).ToList();

        // Assert
        stages.Should().BeEquivalentTo(expected.Select(stage => new KeyStage(stage.First, stage.Second)));  
    }
}