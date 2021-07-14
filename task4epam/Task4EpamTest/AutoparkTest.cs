using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task4epam;

namespace Task4EpamTest
{
    [TestClass]
    public class AutoparkTest
    {
        static Bus scania = new BusBuilder().Create();
        static Car renault = new CarBuilder().Create();
        static Scooter honda = new ScooterBuilder().Create();
        static Truck peterbilt = new TruckBuilder().Create();
        Autopark park = new Autopark(new List<Vehicle> { scania, renault, honda, peterbilt });

        [TestMethod]
        public void GetAutoByParameterTest()
        {
            var dieselVehicles = park.GetAutoByParameter(x => x.Engine.Type, EngineType.Diesel);
            CollectionAssert.AreEqual(new List<Vehicle> { scania, peterbilt }, dieselVehicles);
        }
    }
}
