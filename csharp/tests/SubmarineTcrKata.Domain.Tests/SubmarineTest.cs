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
}