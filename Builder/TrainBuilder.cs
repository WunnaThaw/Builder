using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>

    class TrainBuilder : VehicleBuilder
    {
        public TrainBuilder()
        {
            vehicle = new Vehicle("Train");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Train Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "0";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "20";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "10";
        }
    }
}
