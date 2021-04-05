using BenchmarkDotNet.Running;
using benchmarks_labs.CollectionsBenchmarks;
using System;

namespace benchmarks_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListBenchmark>();
        }
    }
}
