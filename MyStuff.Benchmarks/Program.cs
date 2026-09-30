using BenchmarkDotNet.Running;

namespace MyStuff.Benchmarks;

// 1. Minimise external variables: Close Visual Studio and any other applications that may affect the benchmark results
// 2. Open a terminal and navigate to this project folder
// 3. Run this command to run the benchmarker:
//      dotnet run -c Release 

public static class Program
{
    // Entry point of the benchmarker.
    public static void Main(string[] args)
    {
        var t = new StringBenchmarks();
        var result = t.JoinUsingPlusOperator();
        var summary = BenchmarkRunner.Run<StringBenchmarks>();
    }
}
