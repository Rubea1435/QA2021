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

        protected Vehicle() { }

        protected Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        /// <summary>
        /// It creates a string that contains all class fields information
        /// </summary>
        /// <returns>String with full information</returns>
        public virtual string GetFullInfo()
        {
            return "engine power = " + Engine.Power + ", engine size = " + Engine.Size +
                ", engine type = " + Engine.Type + ", engine serial number = " + Engine.SerialNumber +
                ", wheels number = " + Chassis.WheelsNumber + ", chassis serial number = " + Chassis.SerialNumber +
                ", allowed load = " + Chassis.AllowedLoad + ", transmission type = " + Transmission.Type +
                ", gear number = " + Transmission.GearNumber + ", transmission producer = " + Transmission.Producer;
        }
    }
}
