namespace MyStuff.MyClasses.Tests;

public class DigitSummerTests
{
    [Fact]
    public void SumUsingLinq_Works()
    {
        var result = DigitSummer.SumUsingLinq(123456789);

        Assert.Equal(45, result);
    }

    [Fact]
    public void Blah()
    {
        var strings = GetStrings(10000, 100);
        var result = StringJoins.JoinWithPlusOperator(strings);
    }

    private static IEnumerable<string> GetStrings(int count, int maxLengthOfSingleString)
    {
        var lengthGenerator = new Random();
        var stringGenerator = new Random();

        return Enumerable.Range(1, count)
                         .Select(_ => stringGenerator.GetHexString(lengthGenerator.Next(maxLengthOfSingleString)));
    }
}
