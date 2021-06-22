using System;
using System.Xml.Serialization;

namespace task4epam
{
    /// <summary>
    /// base class for vehicle types
    /// </summary>
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

        /// <summary>
        /// It creates a string that contains all class fields information
        /// </summary>
        /// <returns>String with full information</returns>
        public abstract string GetFullInfo();
    }
}
