using System;

namespace task4epam
{
    public class Bus : Vehicle
    {
        public int PassengerSeats { get; set; }

        public Bus() { }

        public Bus(Engine engine, Chassis chassis, Transmission transmission, int passengerSeats)
            : base(engine, chassis, transmission)
        {           
            if (passengerSeats > 0)
                PassengerSeats = passengerSeats;
            else throw new InitializationException("Passenger seats number should be positive.");
        }

        public override string GetFullInfo()
        {
            return "Bus: " + base.GetFullInfo() + ", passenger seats number = " + PassengerSeats;
        }
    }
}
