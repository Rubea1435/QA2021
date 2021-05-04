using System;

namespace task6
{
    class JustTriangle : Triangle
    {
        public JustTriangle(Point point1, Point point2, Point point3, Colours colour) : base(point1, point2, point3, colour)
        {
        }

        public override double Square()
        {
            double side1 = Point1.Distance(Point2);
            double side2 = Point1.Distance(Point3);
            double side3 = Point2.Distance(Point3);
            double perimeter = side1 + side2 + side3; // Heron's formula
            double square = Math.Sqrt(perimeter/2 * (perimeter/2 - side1) * (perimeter/2 - side2) * (perimeter/2 - side3));
            return square;
        }
    }
}
