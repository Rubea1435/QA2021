using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Car : Vehicle
    {
        public string WheelDrive { get; } // chassis configuration

        public Car(double engineSize, string transmission, int maxSpeed, string wheelDrive) : base(engineSize, transmission, maxSpeed)
        {
            WheelDrive = wheelDrive;
        }

        public override string GetFullInfo()
        {
            return "Car: engine size = " + EngineSize.ToString() + ", transmission = " + Transmission +
                ", max speed = " + MaxSpeed.ToString() + ", wheel drive = " + WheelDrive;
        }
    }
}
