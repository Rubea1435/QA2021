using System;
using System.Collections.Generic;

namespace task4epam
{
    class Program
    {
        static void Main(string[] args)
        {
            BusBuilder scaniaBusBuilder = new BusBuilder();
            CarBuilder cityCarBuilder = new CarBuilder();
            ScooterBuilder hondaScooterBuilder = new ScooterBuilder();
            TruckBuilder peterbiltTruckBuilder = new TruckBuilder();

            Bus scania = scaniaBusBuilder.Create();
            Car renault = cityCarBuilder.Create();
            Scooter honda = hondaScooterBuilder.Create();
            Truck peterbilt = peterbiltTruckBuilder.Create();

            List<Vehicle> allVehicles = new List<Vehicle> { scania, renault, honda, peterbilt };
            foreach (Vehicle item in allVehicles)
                Console.WriteLine(item.GetFullInfo());
        }
    }
}
