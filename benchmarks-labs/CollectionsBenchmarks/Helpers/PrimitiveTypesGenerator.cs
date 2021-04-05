using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmarks_labs.CollectionsBenchmarks.Helpers
{
    public class PrimitiveTypesGenerator
    {
        public static IEnumerable<int> GenerateIntegers(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                yield return i;
            }
        }
    }
}
