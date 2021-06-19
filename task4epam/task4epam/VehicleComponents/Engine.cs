using System;

namespace task4epam
{
    public class Engine
    {
        public int Power { get; set; } // horsepower
        public double Size { get; set; } // litres
        public EngineType Type { get; set; }
        public int SerialNumber { get; set; }

        public Engine() { }

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
