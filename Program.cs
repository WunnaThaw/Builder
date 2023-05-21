using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Store store = new Store();

            // Construct and display vehicles
            builder = new TrainBuilder();
            store.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            store.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            store.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
