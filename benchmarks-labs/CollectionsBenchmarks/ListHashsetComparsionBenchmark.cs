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
    public class ListHashsetComparsionBenchmark
    {
        private const int _dummyModelCountBig = 1000000;
        private const int _dummyModelCountMedium = 500000;
        private const int _dummyModelCountSmall = 100000;
        private readonly HashSet<DummyModel> _hashsetBig;
        private readonly HashSet<DummyModel> _hashsetMedium;
        private readonly HashSet<DummyModel> _hashsetSmall;
        private readonly List<DummyModel> _listBig;
        private readonly List<DummyModel> _listMedium;
        private readonly List<DummyModel> _listSmall;
        public ListHashsetComparsionBenchmark()
        {
            _hashsetBig = new HashSet<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountBig));
            _hashsetMedium = new HashSet<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountMedium));
            _hashsetSmall = new HashSet<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountSmall));
            _listBig = new List<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountBig));
            _listMedium = new List<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountMedium));
            _listSmall = new List<DummyModel>(DummyModelsGenerator.Generate(_dummyModelCountSmall));
        }
        [Benchmark]
        public void BigHashSetAddBenchmark() 
        {
            _hashsetBig.Add(DummyModel.Default);
        }
        [Benchmark]
        public void MediumHashSetAddBenchmark()
        {
            _hashsetMedium.Add(DummyModel.Default);
        }
        [Benchmark]
        public void SmallHashSetAddBenchmark()
        {
            _hashsetSmall.Add(DummyModel.Default);
        }
        [Benchmark]
        public void BigListAddBenchmark()
        {
            _listBig.Add(DummyModel.Default);
        }
        [Benchmark]
        public void MediumListAddBenchmark()
        {
            _listMedium.Add(DummyModel.Default);
        }
        [Benchmark]
        public void SmallListAddBenchmark()
        {
            _listSmall.Add(DummyModel.Default);
        }
    }
}
