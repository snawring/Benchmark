using BenchmarkDotNet.Attributes;
using MyStuff.MyClasses;

namespace MyStuff.Benchmarks;

// All benchmark code is contained in this project, separate from other code.

[RPlotExporter]
public class StringBenchmarks
{
    public IEnumerable<string> Strings { get; set; } = [];

    [Params(10, 100, 1000, 10000)]
    public int NumberOfStrings { get; set; }

    [Params(10, 100)]
    public int MaxLengthOfSingleString { get; set; }

    [Benchmark]
    public string JoinUsingPlusOperator() => StringJoins.JoinWithPlusOperator(Strings);  // Wrapper for the benchmark candidate

    [Benchmark]
    public string JoinWithJoinMethod() => StringJoins.JoinWithStringJoin(Strings);  // Another wrapper 

    [Benchmark]
    public string JoinWithStringBuilder() => StringJoins.JoinWithStringBuilder(Strings);  // Another wrapper

    [GlobalSetup]
    public void Setup()
    {
        Strings = GetStrings();
    }

    private IEnumerable<string> GetStrings()
    {
        var lengthGenerator = new Random();
        var stringGenerator = new Random();

        return Enumerable.Range(1, NumberOfStrings)
                         .Select(n => stringGenerator.GetHexString(lengthGenerator.Next(MaxLengthOfSingleString)));
    }
}
