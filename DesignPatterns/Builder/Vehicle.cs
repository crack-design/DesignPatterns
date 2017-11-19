using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Vehicle
    {
        private string vehicleType;
        private Dictionary<string, string> parts =
            new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            if (string.IsNullOrEmpty(vehicleType))
            {
                throw new ArgumentException("message", nameof(vehicleType));
            }

            this.vehicleType = vehicleType;
        }
        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n----------------");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Frame: {parts["frame"]}");
            Console.WriteLine($"Engine: {parts["engine"]}");
            Console.WriteLine($"Wheels: {parts["wheels"]}");
            Console.WriteLine($"Doors: {parts["doors"]}");
        }
    }
}
