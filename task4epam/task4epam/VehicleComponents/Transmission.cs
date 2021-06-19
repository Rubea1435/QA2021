using System;

namespace task4epam
{
    public class Transmission
    {
        public TransmissionType Type { get; set; }
        public int GearNumber { get; set; }
        public string Producer { get; set; }

        public Transmission() { }

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
