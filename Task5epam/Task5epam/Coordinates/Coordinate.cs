using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    public struct Coordinate
    {
        public double X;
        public double Y;
        public double Z;

        /// <summary>
        /// In task it's required that coordinates are positive
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(double x, double y, double z)
        {
            if (x >= 0 && y >= 0 && z >= 0)
            {
                X = x;
                Y = y;
                Z = z;
            }
            else throw new ArgumentOutOfRangeException("Coordinates can't be negative.");
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="coord">Another 3D coordinate</param>
        /// <returns>Distance</returns>
        public double GetDistance(Coordinate coord)
        {
            double shiftingX = X - coord.X;
            double shiftingY = Y - coord.Y;
            double shiftingZ = Z - coord.Z;
            double distance = Math.Sqrt(shiftingX * shiftingX + shiftingY * shiftingY + shiftingZ * shiftingZ);
            return distance;
        }
    }
}
