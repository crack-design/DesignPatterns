using System;
using DesignPatterns.Command;
using DesignPatterns.Command.SecondImplementation;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Strategy;

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

            //Receiver receiverObj = new Receiver();

            //ICommand command = new ConcreteCommand(receiverObj, "Johny");

            //var invokerObj = new Command.SecondImplementation.Invoker();

            //invokerObj.SetCommand(command);

            //invokerObj.ExecuteCommand();

            //Console.Read();

            #endregion
            //Запитати про дженерік інтерфейс для команди
            //https://www.cuttingedge.it/blogs/steven/pivot/entry.php?id=91
            #region Adapter

            //var newSocket = new NewSocket();
            //AdapterConsumer.Charge(newSocket);
            //var oldSocket = new OldSocket();
            //var adapter = new Adapter.Adapter(oldSocket);
            //AdapterConsumer.Charge(adapter);
            ////Vice versa
            //var adapterForNewSocket = new Adapter.Adapter(newSocket);
            //AdapterConsumer.ChargeViaOldSocket(adapterForNewSocket);
            //Console.ReadLine();
            #endregion

            #region Builder
            VehicleBuilder builder;

            var shop = new Director();
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadLine();
            #endregion

            #region Strategy

            SortedList records = new SortedList();

            records.Add("Jack");
            records.Add("Jill");
            records.Add("Smith");
            records.Add("Mike");
            records.Add("Abbyy");

            records.SetSortStrategy(new QuickSort());
            records.Sort();

            records.SetSortStrategy(new MergeSort());
            records.Sort();

            Console.ReadKey();

            #endregion
        }
    }
}
