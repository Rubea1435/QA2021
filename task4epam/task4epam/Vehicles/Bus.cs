using System;

namespace task4epam
{
    public class Bus : Vehicle
    {
        private int _passengerSeats;
        public int PassengerSeats
        {
            get
            {
                return _passengerSeats;
            }
            set
            {
                if (value > 0)
                    _passengerSeats = value;
                else throw new InitializationException("Passenger seats number should be positive.");
            }
        }

        public Bus() { }
        public Bus(Engine engine, Chassis chassis, Transmission transmission, int passengerSeats)
            : base(engine, chassis, transmission)
        {           
            PassengerSeats = passengerSeats;
        }

        public override string GetFullInfo()
        {
            return "Bus: " + base.GetFullInfo() + ", passenger seats number = " + PassengerSeats;
        }
    }
}
