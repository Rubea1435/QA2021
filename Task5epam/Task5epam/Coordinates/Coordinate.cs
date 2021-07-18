using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    public class Coordinate
    {
        private double _x;
        public double X 
        {
            get
            {
                return _x;
            }

            set
            {
                if (value >= 0)
                {
                    _x = value;
                }
                else throw new ArgumentOutOfRangeException("Coordinates can't be negative.");
            }
        }

        private double _y;
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
                else throw new ArgumentOutOfRangeException("Coordinates can't be negative.");
            }
        }

        private double _z;
        public double Z
        {
            get
            {
                return _z;
            }

            set
            {
                if (value >= 0)
                {
                    _z = value;
                }
                else throw new ArgumentOutOfRangeException("Coordinates can't be negative.");
            }
        }

        /// <summary>
        /// In task it's required that coordinates are positive
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
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
