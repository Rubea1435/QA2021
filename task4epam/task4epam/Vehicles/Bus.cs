using System;

namespace task4epam
{
    class Bus : Vehicle
    {
        public int PassengerSeats { get; }
        public Bus(Engine engine, Chassis chassis, Transmission transmission, int passengerSeats)
            : base(engine, chassis, transmission)
        {           
            if (passengerSeats > 0)
                PassengerSeats = passengerSeats;
            else throw new ArgumentOutOfRangeException("Passenger seats number should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Bus: engine power = " + Engine.Power + ", engine size = " + Engine.Size +
                ", engine type = " + Engine.Type + ", engine serial number = " + Engine.SerialNumber +
                ", wheels number = " + Chassis.WheelsNumber + ", chassis serial number = " + Chassis.SerialNumber +
                ", allowed load = " + Chassis.AllowedLoad + ", transmission type = " + Transmission.Type +
                ", gear number = " + Transmission.GearNumber + ", transmission producer = " + Transmission.Producer +
                ", passenger seats number = " + PassengerSeats;
        }
    }
}
