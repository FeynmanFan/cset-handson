using Xunit;

namespace Exercises.Tests;

public class ValidationTests
{
    [Fact]
    public void Exercise1()
    {
        var calculator = new Calculator();

        Assert.Equal(20, calculator.Calculate((x, y) => x * y, 5, 4));
    }
}