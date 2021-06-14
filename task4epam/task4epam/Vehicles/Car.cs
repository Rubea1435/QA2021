using System;

namespace task4epam
{
    class Car : Vehicle
    {
        public int MaxSpeed { get; } // km/h
        public Car(Engine engine, Chassis chassis, Transmission transmission, int maxSpeed)
            : base(engine, chassis, transmission)
        {
            if (maxSpeed > 0)
                MaxSpeed = maxSpeed;
            else throw new ArgumentOutOfRangeException("Max speed should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Car: engine power = " + Engine.Power + ", engine size = " + Engine.Size +
                ", engine type = " + Engine.Type + ", engine serial number = " + Engine.SerialNumber +
                ", wheels number = " + Chassis.WheelsNumber + ", chassis serial number = " + Chassis.SerialNumber +
                ", allowed load = " + Chassis.AllowedLoad + ", transmission type = " + Transmission.Type +
                ", gear number = " + Transmission.GearNumber + ", transmission producer = " + Transmission.Producer +
                ", max speed = " + MaxSpeed;
        } 
    }
}
