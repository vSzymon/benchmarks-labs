using BenchmarkDotNet.Attributes;
using benchmarks_labs.CollectionsBenchmarks.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmarks_labs.CollectionsBenchmarks
{
    [MemoryDiagnoser]
    public class ListBenchmark
    {
        private const int _dummyModelMaxCount = 100000;
        [Benchmark]
        public List<DummyModel> ToListLinq() 
        {
            return DummyModelsGenerator.Generate(_dummyModelMaxCount).ToList();
        }
        [Benchmark]
        public List<DummyModel> ToListWithAccurateCapacity()
        {
            var list = new List<DummyModel>(_dummyModelMaxCount);
            
            foreach (var item in DummyModelsGenerator.Generate(_dummyModelMaxCount))
            {
                list.Add(item);
            }
            return list;
        }
        [Benchmark]
        public List<DummyModel> ToListWithEstimatedCapacity()
        {
            var capacityEstimation = 40000;
           
            var list = new List<DummyModel>(capacityEstimation);
           
            foreach (var item in DummyModelsGenerator.Generate(_dummyModelMaxCount))
            {
                list.Add(item);
            }
            return list;
        }
    }
}
