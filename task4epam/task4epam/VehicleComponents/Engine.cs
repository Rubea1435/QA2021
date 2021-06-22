using System;

namespace task4epam
{
    /// <summary>
    /// Vehicle component
    /// </summary>
    public class Engine
    {
        public int Power { get; set; } // horsepower
        public double Size { get; set; } // litres
        public EngineType Type { get; set; }
        public int SerialNumber { get; set; }

        public Engine() { } // for serialization

        /// <summary>
        /// Engine constructor with constraints
        /// </summary>
        /// <param name="power">Natural number in horsepowers</param>
        /// <param name="size">Real number of engine size in litres</param>
        /// <param name="type">Type of fuel from enum</param>
        /// <param name="serialNumber">Serial number starts with number 1</param>
        public Engine(int power, double size, EngineType type, int serialNumber)
        {
            Type = type;
            if (power > 0)
                Power = power;
            else throw new ArgumentOutOfRangeException("Engine power should be positive.");
            if (size > 0)
                Size = size;
            else throw new ArgumentOutOfRangeException("Engine size should be positive.");
            if (serialNumber > 0)
                SerialNumber = serialNumber;
            else throw new ArgumentOutOfRangeException("Serial number should be positive.");
        }
    }
}
