using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Bus : Vehicle
    {
        public int PassengerSeats { get; } // amount

        public Bus(double engineSize, string transmission, int maxSpeed, int passengerSeats) : base(engineSize, transmission, maxSpeed)
        {
            PassengerSeats = passengerSeats;
        }

        public override string GetFullInfo()
        {
            return "Bus: engine size = " + EngineSize.ToString() + ", transmission = " + Transmission +
                ", max speed = " + MaxSpeed.ToString() + ", passenger seats = " + PassengerSeats.ToString();
        }
    }
}
