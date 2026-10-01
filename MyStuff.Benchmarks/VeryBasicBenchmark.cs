using BenchmarkDotNet.Attributes;
using MyStuff.MyCode;

namespace MyStuff.Benchmarks
{
    public class VeryBasicBenchmark
    {
        [Benchmark(Description = $"Join 200 strings using concatenation")]
        public string CallJoinWithStringConcatenation() => StringThings.JoinWithStringConcatenation(Enumerable.Repeat("some string", 200)); 

        [Benchmark(Description = "Join strings using StringBuilder")]
        public string CallJoinWithStringBuilder() => StringThings.JoinWithStringBuilder(Enumerable.Repeat("some string", 200));
    }
}
