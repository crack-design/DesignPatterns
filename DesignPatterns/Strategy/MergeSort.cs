using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class MergeSort : SortingStrategy
    {
        public override List<string> Sort(List<string> list)
        {
            var length = list.Count;

            if (length < 2)
                return list;

            List<string> left = Sort(list.GetRange(0, length / 2));
            List<string> right = Sort(list.GetRange(length / 2, length - length / 2));
            var result = new List<string>();
            for (int leftIndex = 0, leftLength = left.Count, rightLength = right.Count, rightIndex = 0; leftIndex + rightIndex < length;)
            {
                if (rightIndex >= rightLength || leftIndex < leftLength && String.Compare(left[leftIndex], right[rightIndex], StringComparison.Ordinal) <= 0)
                    result.Add(left[leftIndex++]);
                else
                    result.Add(right[rightIndex++]);
            }

            return result;
        }
    }
}
