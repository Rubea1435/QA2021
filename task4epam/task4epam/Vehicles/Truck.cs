using System;

namespace task4epam
{
    public class Truck : Vehicle
    {
        private int _maxTrailerWeight;
        public int MaxTrailerWeight // kilograms
        {
            get
            {
                return _maxTrailerWeight;
            }
            set
            {
                if (value > 0)
                    _maxTrailerWeight = value;
                else throw new InitializationException("Max trailer weight should be positive.");
            }
        }

        public Truck() { }
        public Truck(Engine engine, Chassis chassis, Transmission transmission, int maxTrailerWeight)
            : base(engine, chassis, transmission)
        {
            MaxTrailerWeight = maxTrailerWeight;
        }

        public override string GetFullInfo()
        {
            return "Truck: " + base.GetFullInfo() + ", max trailer weight = " + MaxTrailerWeight;
        }
    }
}