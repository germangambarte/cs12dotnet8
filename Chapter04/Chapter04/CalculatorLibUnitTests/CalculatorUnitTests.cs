using CalculatorLib;

namespace CalculatorLibUnitTest;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        double x = 2;
        double y = 2;
        double expected = 4;

        Calculator calc = new();

        Assert.Equal(expected, calc.Add(x, y));
    }

    [Fact]
    public void TestAdding2And3()
    {
        double x = 2;
        double y = 3;
        double expected = 5;

        Calculator calc = new();

        Assert.Equal(expected, calc.Add(x, y));
    }
}