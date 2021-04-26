using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    abstract class Vehicle
    {
        public double EngineSize { get; }    // in litres
        public string Transmission { get; } // type
        public int MaxSpeed { get; }        // in km/h

        public Vehicle(double engineSize, string transmission, int maxSpeed)
        {
            EngineSize = engineSize;
            Transmission = transmission;
            MaxSpeed = maxSpeed; 
        }

        public abstract string GetFullInfo();
    }
}
