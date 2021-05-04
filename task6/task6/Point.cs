using System;

namespace task6
{
    class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance (Point otherPoint)
        {
            return Math.Sqrt(((X - otherPoint.X) * (X - otherPoint.X)) + ((Y - otherPoint.Y) * (Y - otherPoint.Y)));
        }
    }
}
