using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class VolkswagenPassat : IVehicle
    {
        public string Make { get => "Volkswagen"; }
        public string Model { get => "Passat"; }
        public double Price { get => 30000; }
    }
}
