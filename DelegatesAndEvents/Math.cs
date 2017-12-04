using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static long DurableMultiply(int a, int b)
        {
            Thread.Sleep(2000);
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
