using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class QuickSort : SortingStrategy
    {
        public override List<string> Sort(List<string> list)
        {
            list.Sort();
            return list;
        }
    }
}
