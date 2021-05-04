using System;

namespace task6
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point point1, Point point2, Point point3, Colours colour) : base(point1, point2, point3, colour)
        {
        }

        public override double Square()
        {
            double side = Point1.Distance(Point2);
            double square = side * side * Math.Sqrt(3) / 4;
            return square;
        }
    }
}
