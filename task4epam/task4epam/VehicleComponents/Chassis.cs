using System;

namespace task4epam
{
    public class Chassis
    {
        public int WheelsNumber { get; set; } 
        public int SerialNumber { get; set; }
        public int AllowedLoad { get; set; } // kilograms

        public Chassis() { }

        public Chassis(int wheelsNumber, int serialNumber, int allowedLoad)
        {
            if (wheelsNumber > 0)
                WheelsNumber = wheelsNumber;
            else throw new ArgumentOutOfRangeException("Wheels number should be positive.");
            if (serialNumber > 0)
                SerialNumber = serialNumber;
            else throw new ArgumentOutOfRangeException("Serial number should be positive.");
            if (allowedLoad > 0)
                AllowedLoad = allowedLoad;
            else throw new ArgumentOutOfRangeException("Allowed load should be positive.");
        }
    }
}
