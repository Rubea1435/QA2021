using System;

namespace task4epam
{
    public class Car : Vehicle
    {
        public int MaxSpeed { get; set; } // km/h

        public Car() { }

        public Car(Engine engine, Chassis chassis, Transmission transmission, int maxSpeed)
            : base(engine, chassis, transmission)
        {
            if (maxSpeed > 0)
                MaxSpeed = maxSpeed;
            else throw new InitializationException("Max speed should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Car: " + base.GetFullInfo() + ", max speed = " + MaxSpeed;
        }
    }
}
