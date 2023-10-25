using System;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void Add_ShouldReturnSum()
    {
        // Arrange
        int a = 5;
        int b = 7;
        int expectedSum = 12;

        // Act
        int actualSum = Program.Add(a, b);

        // Assert
        Assert.Equal(expectedSum, actualSum);
    }
}
