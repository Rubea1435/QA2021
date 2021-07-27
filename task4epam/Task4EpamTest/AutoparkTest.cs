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

        [TestInitialize]
        public void SetID()
        {
            scania.ID = 1;
            renault.ID = 2;
            honda.ID = 3;
            peterbilt.ID = 4;
        }

        [TestMethod]
        [ExpectedException(typeof(AddException))]
        public void AddExceptionTest()
        {
            Bus busWithSameID = new BusBuilder().Create();
            busWithSameID.ID = 2;
            park.AddVehicle(busWithSameID);
        }

        [TestMethod]
        [ExpectedException(typeof(InitializationException))]
        public void InitializationExceptionTest()
        {
            Car carWithNegativeMaxSpeed = new CarBuilder().Create();
            carWithNegativeMaxSpeed.MaxSpeed = -10;
        }

        [TestMethod]
        public void GetAutoByParameterTest()
        {
            var dieselVehicles = park.GetAutoByParameter(x => x.Engine.Type, EngineType.Diesel);
            CollectionAssert.AreEqual(new List<Vehicle> { scania, peterbilt }, dieselVehicles);
        }

        [TestMethod]
        [ExpectedException(typeof(UpdateAutoException))]
        public void UpdateAutoExceptionTest()
        {
            park.UpdateVehicle(14, new CarBuilder().Create());
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveAutoException))]
        public void RemoveAutoExceptionTest()
        {
            park.RemoveVehicle(14);
        }
    }
}
