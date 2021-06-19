using System;

namespace task4epam
{
    public class Truck : Vehicle
    {
        public int MaxTrailerWeight { get; set; } // kilograms

        public Truck() { }

        public Truck(Engine engine, Chassis chassis, Transmission transmission, int maxTrailerWeight)
            : base(engine, chassis, transmission)
        {
            if (maxTrailerWeight > 0)
                MaxTrailerWeight = maxTrailerWeight;
            else throw new ArgumentOutOfRangeException("Max trailer weight should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Car: engine power = " + Engine.Power + ", engine size = " + Engine.Size +
                ", engine type = " + Engine.Type + ", engine serial number = " + Engine.SerialNumber +
                ", wheels number = " + Chassis.WheelsNumber + ", chassis serial number = " + Chassis.SerialNumber +
                ", allowed load = " + Chassis.AllowedLoad + ", transmission type = " + Transmission.Type +
                ", gear number = " + Transmission.GearNumber + ", transmission producer = " + Transmission.Producer +
                ", max trailer weight = " + MaxTrailerWeight;
        }
    }
}
