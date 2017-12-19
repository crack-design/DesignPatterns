using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion
            byte a = 255;
            int b = a;

            Derived d = new Derived();
            Base bc = d;

            //Explicit conversion - cast

            double x = 1344.24;
            int z;
            z = (int)x;

            Base bc2 = new Base();
            try
            {
                Derived d2 = (Derived)bc2; //throws InvalidCastException
            }
            catch (InvalidCastException)
            {
            }
            

            //User-defined conversions - explicit and implicit
            SampleClassBase sbc = (SampleClassBase)100;
            int value = sbc;

            //is - as operators

            //Conversion with helper classes

            byte[] bytes = { 0, 2, 4, 255 };

            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            int i = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine($"int is {i}");

            //Hexadecimal conversion

            string input = "Big white bunny";
            char[] values = input.ToCharArray();
            string[] hexes = new string[input.Length];
            var count = 0;
            foreach (char letter in  values)
            {
                
                int item = Convert.ToInt32(letter);
                string hexOut = String.Format("{0:X}", item);
                hexes[count] = hexOut;
;               Console.WriteLine($"Hex of {letter} is {hexOut}");
                count++;
            }
            foreach (var item in hexes)
            {
                int val = Convert.ToInt32(item, 16);

                string stringVal = Char.ConvertFromUtf32(val);
                char charVal = (char)val;
                Console.WriteLine($"Hex = {item}, int = {val}, char = {stringVal} or {charVal}");
            }

            Console.ReadLine();
        }
    }

    class Base { }

    class Derived : Base { }

    class SampleClassBase
    {
        private int id;
        public static explicit operator SampleClassBase(int i)
        {
            return new SampleClassBase { id = i };
        }
        public static implicit operator int (SampleClassBase sbc)
        {
            return sbc.id;
        }
    }
}
