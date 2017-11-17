using System;
using DesignPatterns.Command;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Command

            Client client = new Client();
            client.Compute('+', 20, 150);
            Console.ReadLine();
            #endregion
        }
    }
}
