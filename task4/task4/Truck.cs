using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Truck : Vehicle
    {
        public int LoadCapacity { get; } // in kilograms

        public Truck(double engineSize, string transmission, int maxSpeed, int loadCapacity) : base(engineSize, transmission, maxSpeed)
        {
            LoadCapacity = loadCapacity;
        }

        public override string GetFullInfo()
        {
            return "Truck: engine size = " + EngineSize.ToString() + ", transmission = " + Transmission + 
                ", max speed = " + MaxSpeed.ToString() + ", load capacity = " + LoadCapacity.ToString();
        }
    }
}
