using FluentAssertions;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit.TestUtils;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Tests.Unit;

public class LootTests
{
    [Fact]
    public void Create_WhenMinQuantityLessThan0_ShouldFail()
    {
        var result = LootFactory.CreateLoot(minQuantity: -1);
        
        result.IsError.Should().BeTrue();
        result.FirstError.Code.Should().Be(LootErrors.MinQuantityCantBeLessThan0.Code);
    }

    [Fact]
    public void Create_WhenMinQuantityGreaterThanMaxQuantity_ShouldFail()
    {
        var result = LootFactory.CreateLoot(
            minQuantity: 10,
            maxQuantity: 5);

        result.IsError.Should().BeTrue();
        result.FirstError.Code.Should().Be(LootErrors.MinQuantityExceedsMaxQuantity.Code);
    }

    [Fact]
    public void Create_WhenMaxQuantityLessThan0_ShouldFail()
    {
        var result = LootFactory.CreateLoot(
            minQuantity: 0,
            maxQuantity: -1);
        
        result.IsError.Should().BeTrue();
        result.FirstError.Code.Should().Be(LootErrors.MinQuantityExceedsMaxQuantity.Code); 
    }
}