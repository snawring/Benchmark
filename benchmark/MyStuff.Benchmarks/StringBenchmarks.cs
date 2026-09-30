using BenchmarkDotNet.Attributes;
using MyStuff.MyClasses;

namespace MyStuff.Benchmarks;

// All benchmark code is contained in this project.
public class StringBenchmarks
{
    [Params(10, 100, 1000, 10000)]  
    public static int NumberOfStrings { get; set; }

    [Params(10, 100)]
    public static int MaxLengthOfSingleString { get; set; }

    [Benchmark]
    public string JoinUsingPlusOperator() => StringJoins.JoinWithPlusOperator(Strings);  // Wrapper for the benchmark candidate

    [Benchmark]
    public string JoinWithJoinMethod() => StringJoins.JoinWithStringJoin(Strings);  // Wrapper for the benchmark candidate

    public IEnumerable<string> Strings { get; set; } = GetStrings(NumberOfStrings, MaxLengthOfSingleString);

    private static IEnumerable<string> GetStrings(int count, int maxLengthOfSingleString)
    {
        var lengthGenerator = new Random();
        var stringGenerator = new Random();

        return Enumerable.Range(1, count)
                         .Select(_ => stringGenerator.GetHexString(lengthGenerator.Next(maxLengthOfSingleString)));
    }
}
