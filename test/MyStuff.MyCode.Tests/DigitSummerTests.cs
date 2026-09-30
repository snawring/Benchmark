namespace MyStuff.MyClasses.Tests;

public class DigitSummerTests
{
    [Fact]
    public void SumUsingLinq_Works()
    {
        var result = DigitSummer.SumUsingLinq(123456789);

        Assert.Equal(45, result);
    }
}
