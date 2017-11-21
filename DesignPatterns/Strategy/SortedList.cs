using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class SortedList
    {
        private List<string> list = new List<string>();

        private SortingStrategy strategy;

        public void SetSortStrategy(SortingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            this.strategy.Sort(list);
            foreach (var record in list)
            {
                Console.WriteLine($"{record}");
            }
        }

    }
}
