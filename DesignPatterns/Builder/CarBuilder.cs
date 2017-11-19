using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }
        public override void BuildDoors()
        {
            Vehicle["doors"] = "5";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "1968cc";

        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Frame for Car";

        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "4";

        }
    }
}
