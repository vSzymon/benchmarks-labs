using System;
using System.Collections.Generic;

namespace benchmarks_labs.CollectionsBenchmarks.Helpers
{
    public class DummyModelsGenerator
    {
        public static IEnumerable<DummyModel> Generate(int count) 
        {
            for (int i = 0; i <= count; i++)
            {
                yield return new DummyModel
                {
                    A = 100,
                    B = "DummyString",
                    C = DateTime.Now,
                    D = 100.100M
                };
            }
        }
        public static IEnumerable<DummyModel> GenerateRandom(int count)
        {
            var random = new Random();
            for (int i = 0; i <= count; i++)
            {
                yield return new DummyModel
                {
                    A = random.Next(1, 100),
                    B = Guid.NewGuid().ToString(),
                    C = DateTime.Now,
                    D = (decimal)random.NextDouble()
                };
            }
        }
    }
}
