using System;

namespace task4epam
{
    /// <summary>
    /// class needed to serialize only engine types, serial numbers and powers
    /// because Tuple is not serializable in .NET
    /// </summary>
    [Serializable]
    public struct EngineWithoutSize
    {
        public EngineType Type { get; set; }
        public int SerialNumber { get; set; }
        public int Power { get; set; } // horsepower

        /// <summary>
        /// A copy of Engine constrictor but without size
        /// </summary>
        /// <param name="type"></param>
        /// <param name="serialNumber"></param>
        /// <param name="power"></param>
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
