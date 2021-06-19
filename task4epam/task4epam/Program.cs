using System;
using System.Collections.Generic;
using System.Linq;

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

            List<Vehicle> vehiclesWithBigEngineSize = allVehicles.Where(x => x.Engine.Size > 1.5).ToList();

            var engineTypesAndNumbersAndPowersForBusesAndTrucks = allVehicles.Where(x => (x is Bus) || (x is Truck))
                .Select(x => new EngineWithoutSize(x.Engine.Type, x.Engine.SerialNumber, x.Engine.Power)).ToList();

            var vehiclesGroupedByTransmissionType = allVehicles.GroupBy(x => x.Transmission.Type).SelectMany(x => x).ToList();

            Serializer.CreateXml("Vehicles with engine size more than 1.5 litre.xml", vehiclesWithBigEngineSize);
            Serializer.CreateXml("Engine types, numbers and powers for all buses and trucks.xml", engineTypesAndNumbersAndPowersForBusesAndTrucks);
            Serializer.CreateXml("Vehicles grouped by transmission type.xml", vehiclesGroupedByTransmissionType);        
        }
    }
}
