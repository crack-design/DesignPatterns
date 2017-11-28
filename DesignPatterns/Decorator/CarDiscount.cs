using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class CarDiscount : VehicleDecorator
    {
        public CarDiscount(IVehicle vehicle) : base(vehicle)
        {
        }

        public int DiscountPercent { get; set; }
        public string Offer { get; set; }
        public new double Price { get
            {
                double price = base.Price;
                int percent = 100 - DiscountPercent;
                return Math.Round((price * percent) / 100, 2);
            }}
    }
}
