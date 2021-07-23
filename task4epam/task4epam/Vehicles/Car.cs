using System;

namespace task4epam
{
    public class Car : Vehicle
    {
        private int _maxSpeed;
        public int MaxSpeed // km/h
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0)
                    _maxSpeed = value;
                else throw new InitializationException("Max speed should be positive.");
            }
        }

        public Car() { }
        public Car(Engine engine, Chassis chassis, Transmission transmission, int maxSpeed)
            : base(engine, chassis, transmission)
        {
            MaxSpeed = maxSpeed;
        }

        public override string GetFullInfo()
        {
            return "Car: " + base.GetFullInfo() + ", max speed = " + MaxSpeed;
        }
    }
}
