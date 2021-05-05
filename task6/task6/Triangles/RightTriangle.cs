using System;
using System.Collections.Generic;

namespace task6
{
    class RightTriangle : Triangle
    {
        public RightTriangle(Point point1, Point point2, Point point3, Colour colour) : base(point1, point2, point3, colour)
        {
        }

        public override double Square()
        {
            double side1 = Point1.Distance(Point2);
            double side2 = Point1.Distance(Point3);
            double side3 = Point2.Distance(Point3);
            List<double> sides = new List<double>();
            sides.Add(side1);
            sides.Add(side2);
            sides.Add(side3);
            sides.Sort(); // two cathets are smaller than the hypotenuse
            double square = sides[0] * sides[1] / 2; 
            return square;
        }

    }
}
