using Xunit;

namespace Exercises.Tests;

public class ValidationTests
{
    [Fact]
    public void Exercise1()
    {
        var calculator = new LambdaTests();

        Assert.Equal(20, calculator.Calculate((x, y) => x * y, 5, 4));
    }
}