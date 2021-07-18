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

        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double GetDistance(Coordinate anotherCoordinate)
        {
            double shiftingX = X - anotherCoordinate.X;
            double shiftingY = Y - anotherCoordinate.Y;
            double shiftingZ = Z - anotherCoordinate.Z;
            double distance = Math.Sqrt(shiftingX * shiftingX + shiftingY * shiftingY + shiftingZ * shiftingZ);
            return distance;
        }
    }
}
