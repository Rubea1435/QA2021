using System;

namespace task4epam
{
    public class Scooter : Vehicle
    {
        public int CruisingRange { get; set; } // kilometers

        public Scooter() { }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission, int cruisingRange)
            : base(engine, chassis, transmission)
        {
            if (cruisingRange > 0)
                CruisingRange = cruisingRange;
            else throw new InitializationException("Cruising range should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Scooter: " + base.GetFullInfo() + ", cruising range = " + CruisingRange;
        }
    }
}
