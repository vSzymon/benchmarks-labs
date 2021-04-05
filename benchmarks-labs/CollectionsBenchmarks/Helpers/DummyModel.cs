using System;

namespace benchmarks_labs.CollectionsBenchmarks.Helpers
{
    public class DummyModel
    {
        public int A { get; set; }
        public string B { get; set; }
        public decimal D { get; set; }
        public DateTime C { get; set; }
        public static DummyModel Default =>
            new DummyModel { A = 0, B = "Default", D = 0M, C = DateTime.MinValue };
    }
}
