using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class VehicleDecorator : IVehicle
    {
        private IVehicle vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Make { get => vehicle.Make; }

        public string Model { get => vehicle.Model; }

        public double Price { get => vehicle.Price; }
    }
}
