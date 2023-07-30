using Conversions = Codeography.Helpers.Conversions;

namespace Codeography.Tests.Helpers;

public sealed class MathTests
{
    [Theory]
    [InlineData(60, 1000)]
    [InlineData(30, 500)]
    [InlineData(120, 2000)]
    public void Converts_To_Milliseconds(int bpm, int expected)
    {
        // Act
        int actual = Conversions.BpmToMilliseconds(bpm);

        // Assert
        Assert.Equal(expected, actual);
    }
}
