using FluentAssertions;
using Xunit;

namespace SubmarineTcrKata.Domain.Tests;

public class SubmarineTest
{
    private readonly Submarine _submarine;

    public SubmarineTest() => _submarine = new Submarine();

    [Fact]
    public void ShouldBeAtZeroPosition()
    {
        _submarine.Aim.Should().Be(0);
        _submarine.Position.Should().Be(0);
        _submarine.Depth.Should().Be(0);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(7)]
    public void ShouldGoDown(int value)
    {
        _submarine.ExecuteCommand("down " + value);

        _submarine.Aim.Should().Be(value);
    }

    [Theory]
    [InlineData(2,3)]
    [InlineData(8,3)]
    public void ShouldGoDownTwice(int firstMove, int secondMove)
    {
        _submarine.ExecuteCommand("down " + firstMove);
        _submarine.ExecuteCommand("down " + secondMove);

        _submarine.Aim.Should().Be(firstMove + secondMove);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(8)]
    public void ShouldGoUp(int value)
    {
        _submarine.ExecuteCommand("up " + value);
        _submarine.Aim.Should().Be(-value);
    }

    [Fact]
    public void ShouldGoUpTwice()
    {
        _submarine.ExecuteCommand("up 5");
        _submarine.ExecuteCommand("up 8");

        _submarine.Aim.Should().Be(-(5 + 8));
    }
}