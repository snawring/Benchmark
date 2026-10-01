using BenchmarkDotNet.Attributes;
using MyStuff.MyCode;

namespace MyStuff.Benchmarks;

public class BenchmarkUsingParameters
{
    public IEnumerable<string> Strings => GetStrings();

    [Params(20, 200, 2000)]
    public int StringCount { get; set; }

    [Params(20, 200)]
    public int MaxLengthOfSingleString { get; set; }

    [Benchmark(Description = "Join strings using concatenation")]
    public string CallJoinWithStringConcatenation() => StringThings.JoinWithStringConcatenation(Strings);  // Wrapper for the benchmark candidate

    [Benchmark(Description = "Join strings using StringBuilder")]
    public string CallJoinWithStringBuilder() => StringThings.JoinWithStringBuilder(Strings);  // Another wrapper

    private IEnumerable<string> GetStrings()
    {
        // Use a fixed seed so that each benchmark run uses the same set of strings.
        var lengthGenerator = new Random(42);
        var stringGenerator = new Random(42);

        return Enumerable.Range(1, StringCount)
                         .Select(n => stringGenerator.GetHexString(lengthGenerator.Next(MaxLengthOfSingleString)));
    }
}
