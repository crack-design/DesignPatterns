using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "650cc";
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Frame for Motorcycle";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }
    }
}
