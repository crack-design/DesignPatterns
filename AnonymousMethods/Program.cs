using System;
using System.Collections.Generic;

namespace AnonymousMethods
{
    delegate int Sum(int number);

    class Program
    {
        static Sum SomeVar()
        {
            int result = 0;
            //https://blogs.msdn.microsoft.com/ruericlippert/2009/11/12/1094/
            //Anonymous method call
            Sum del = delegate (int number)
            {
                for (int i = 0; i <= number; i++)
                    result += i;
                return result;
            };
            return del;
        }

        static void Main()
        {
            Sum del1 = SomeVar();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Sum's {0} equal to: {1}", i, del1(i));
            }

            Console.ReadLine();
        }
    }
}