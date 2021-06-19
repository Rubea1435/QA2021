using System;

namespace task4epam
{
    /// <summary>
    /// class needed to serialize only engine types, serial numbers and powers
    /// </summary>
    [Serializable]
    public struct EngineWithoutSize
    {
        public EngineType Type { get; set; }
        public int SerialNumber { get; set; }
        public int Power { get; set; } // horsepower

        //public EngineWithoutSize() { }

        public EngineWithoutSize(EngineType type, int serialNumber, int power)
        {
            Type = type;
            if (serialNumber > 0)
                SerialNumber = serialNumber;
            else throw new ArgumentOutOfRangeException("Serial number should be positive.");
            if (power > 0)
                Power = power;
            else throw new ArgumentOutOfRangeException("Engine power should be positive.");
        }
    }
}
