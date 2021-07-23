using System;

namespace task4epam
{
    public class Scooter : Vehicle
    {
        private int _cruisingRange;
        public int CruisingRange // kilometers
        {
            get
            {
                return _cruisingRange;
            }
            set
            {
                if (value > 0)
                    _cruisingRange = value;
                else throw new InitializationException("Cruising range should be positive.");
            }
        }

        public Scooter() { }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, int cruisingRange)
            : base(engine, chassis, transmission)
        {
            CruisingRange = cruisingRange;
        }

        public override string GetFullInfo()
        {
            return "Scooter: " + base.GetFullInfo() + ", cruising range = " + CruisingRange;
        }
    }
}
