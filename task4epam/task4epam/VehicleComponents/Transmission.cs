using System;

namespace task4epam
{
    class Transmission
    {
        public TransmissionType Type { get; }
        public int GearNumber { get; }
        public string Producer { get; }

        public Transmission(TransmissionType type, int gearNumber, string producer)
        {
            Type = type;
            Producer = producer;
            if (gearNumber > 0)
                GearNumber = gearNumber;
            else throw new ArgumentOutOfRangeException("Gear number should be positive.");
        }
    }
}
