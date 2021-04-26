using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Motorcycle : Vehicle
    {
        public bool Sidecar { get; } // is there or not

        public Motorcycle(double engineSize, string transmission, int maxSpeed, bool sidecar) : base(engineSize, transmission, maxSpeed)
        {
            Sidecar = sidecar;
        }

        public override string GetFullInfo()
        {
            return "Motorcycle: engine size = " + EngineSize.ToString() + ", transmission = " + Transmission +
                ", max speed = " + MaxSpeed.ToString() + ", sidecar = " + Sidecar.ToString();
        }
    }
}
