using System;

namespace task4epam
{
    /// <summary>
    /// Vehicle component
    /// </summary>
    public class Chassis
    {
        public int WheelsNumber { get; set; } 
        public int SerialNumber { get; set; }
        public int AllowedLoad { get; set; } // kilograms

        public Chassis() { } // for serialization

        /// <summary>
        /// Chassis constructor with constraints
        /// </summary>
        /// <param name="wheelsNumber">Chassis can't be with less than 1 wheel</param>
        /// <param name="serialNumber">Serial number starts with number 1</param>
        /// <param name="allowedLoad">Allowed load is a natural number of kilograms</param>
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
