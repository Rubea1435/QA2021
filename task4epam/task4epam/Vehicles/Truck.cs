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
            else throw new InitializationException("Max trailer weight should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Truck: " + base.GetFullInfo() + ", max trailer weight = " + MaxTrailerWeight;
        }
    }
}