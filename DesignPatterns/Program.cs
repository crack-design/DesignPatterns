using System;
using DesignPatterns.Command;
using DesignPatterns.Command.SecondImplementation;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;
using DesignPatterns.Observer.StockNotifier;
using DesignPatterns.Decorator;
using DesignPatterns.ChainOfResponsibility;

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

            ////Vice versa
            //var adapterForNewSocket = new Adapter.Adapter(newSocket);
            //AdapterConsumer.ChargeViaOldSocket(adapterForNewSocket);
            //Console.ReadLine();
            #endregion

            #region Builder
            //VehicleBuilder builder;

            //var shop = new Director();
            //builder = new MotorCycleBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            //builder = new CarBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();

            //Console.ReadLine();
            #endregion

            #region Strategy

            //SortedList records = new SortedList();

            //records.Add("Jack");
            //records.Add("Jill");
            //records.Add("Smith");
            //records.Add("Mike");
            //records.Add("Abbyy");

            //records.SetSortStrategy(new QuickSort());
            //records.Sort();

            //records.SetSortStrategy(new MergeSort());
            //records.Sort();

            //Console.ReadKey();

            #endregion

            #region Observer
            //LocationTracker provider = new LocationTracker();
            //LocationReporter reporter1 = new LocationReporter("FixedGPS");
            //reporter1.Subscribe(provider);
            //LocationReporter reporter2 = new LocationReporter("MobileGPS");
            //reporter2.Subscribe(provider);

            //provider.TrackLocation(new Location(47.6456, -122.1312));
            //reporter1.Unsubscribe();
            //provider.TrackLocation(new Location(47.6677, -122.1199));
            //provider.TrackLocation(null);
            //provider.EndTransmission();

            //Console.ReadLine();

            #endregion

            #region Observer - StockNotifier
            //Facebook facebook = new Facebook("Facebook", 314.13);
            //facebook.Subscribe(new Investor("Wolf of Wall St."));
            //facebook.Subscribe(new Investor("Richy Rich"));

            //facebook.Price = 356.94;
            //facebook.Price = 315.32;
            //facebook.Price = 301.45;

            //Console.ReadLine();
            #endregion

            #region Decorator

            //VolkswagenPassat car = new VolkswagenPassat();

            //Console.WriteLine($"Car base price is: {car.Price}");

            //CarDiscount discount = new CarDiscount(car);

            //discount.DiscountPercent = 40;
            //discount.Offer = "40% off ";

            //Console.WriteLine($"{discount.Offer} at Alex Lviv Co, so the price is {discount.Price}");

            //Console.ReadKey();
            #endregion

            #region ChainOfResponsibility
            Approver larry = new ChainOfResponsibility.Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}
