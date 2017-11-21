using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    abstract class SortingStrategy
    {
        public abstract List<string> Sort(List<string> list);
    }
}
