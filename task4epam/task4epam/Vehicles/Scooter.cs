using System;

namespace task4epam
{
    class Scooter : Vehicle
    {
        public int CruisingRange { get; } // kilometers
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, int cruisingRange)
            : base(engine, chassis, transmission)
        {
            if (cruisingRange > 0)
                CruisingRange = cruisingRange;
            else throw new ArgumentOutOfRangeException("Cruising range should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Car: engine power = " + Engine.Power + ", engine size = " + Engine.Size +
                ", engine type = " + Engine.Type + ", engine serial number = " + Engine.SerialNumber +
                ", wheels number = " + Chassis.WheelsNumber + ", chassis serial number = " + Chassis.SerialNumber +
                ", allowed load = " + Chassis.AllowedLoad + ", transmission type = " + Transmission.Type +
                ", gear number = " + Transmission.GearNumber + ", transmission producer = " + Transmission.Producer +
                ", cruising range = " + CruisingRange;
        }
    }
}
