using System;
using DesignPatterns.Command;
using DesignPatterns.Command.SecondImplementation;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

#region Command

            //Client client = new Client();
            //client.Compute('+', 20, 150);
            //Console.ReadLine();
            #endregion

#region Command - via interface

            Receiver receiverObj = new Receiver();

            ICommand command = new ConcreteCommand(receiverObj, "Johny");

            var invokerObj = new Command.SecondImplementation.Invoker();

            invokerObj.SetCommand(command);

            invokerObj.ExecuteCommand();

            Console.Read();

            #endregion
            //Запитати про дженерік інтерфейс для команди
            //https://www.cuttingedge.it/blogs/steven/pivot/entry.php?id=91
        }
    }
}
