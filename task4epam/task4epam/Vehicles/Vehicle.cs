using System;
using System.Xml.Serialization;

namespace task4epam
{
    [Serializable]
    [XmlInclude(typeof(Bus)), XmlInclude(typeof(Car)), XmlInclude(typeof(Scooter)), XmlInclude(typeof(Truck))]
    public abstract class Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public Vehicle() { }

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public abstract string GetFullInfo();
    }
}
