using System;

namespace task4epam
{
    /// <summary>
    /// Vehicle component
    /// </summary>
    public class Transmission
    {
        public TransmissionType Type { get; set; }
        public int GearNumber { get; set; }
        public string Producer { get; set; }

        public Transmission() { } // for serialization

        /// <summary>
        /// Transmission constructor with constraints
        /// </summary>
        /// <param name="type"></param>
        /// <param name="gearNumber">Gear numnber starts with 1</param>
        /// <param name="producer"></param>
        public Transmission(TransmissionType type, int gearNumber, string producer)
        {
            Type = type;
            Producer = producer;
            if (gearNumber > 0)
                GearNumber = gearNumber;
            else throw new InitializationException("Gear number should be positive.");
        }
    }
}
