using BenchmarkDotNet.Attributes;
using ClosureCapturing.Core;

namespace ClosureCapturing.Benchmark
{
    [MemoryDiagnoser] // includes memory allocation metrics in the benchmark results
    public class NumberFilterBenchmark
    {
        [Params(100, 500)]
        public int RunCount { get; set; }

        [Benchmark]
        public void NoClosure()
        {
            var filter = new NumberFilter();
            for (int i = 0; i < RunCount; i++)
            {
                filter.A();
            }
        }

        [Benchmark]
        public void WithClosure()
        {
            var filter = new NumberFilter();
            for (int i = 0; i < RunCount; i++)
            {
                filter.B();
            }
        }
    }
}
