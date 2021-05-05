using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class TriangleBuilder
    {
        public Triangle CreateTriangle(Point point1, Point point2, Point point3)
        {
            double side1X = point1.X - point2.X;
            double side1Y = point1.Y - point2.Y;
            double side2X = point1.X - point3.X;
            double side2Y = point1.Y - point3.Y;
            double side3X = point2.X - point3.X;
            double side3Y = point2.Y - point3.Y;
            if (Math.Abs((side1X * side2X) + (side1Y * side2Y)) < double.Epsilon ||   // scalar product, condition of orthogonality
                Math.Abs((side1X * side3X) + (side1Y * side3Y)) < double.Epsilon ||
                Math.Abs((side2X * side3X) + (side2Y * side3Y)) < double.Epsilon)
                return new RightTriangle(point1, point2, point3, Colour.green);
            else if (Math.Abs(point1.Distance(point2) - point1.Distance(point3)) < double.Epsilon &&
                Math.Abs(point1.Distance(point2) - point2.Distance(point3)) < double.Epsilon)
                return new EquilateralTriangle(point1, point2, point3, Colour.red);
            else if (Math.Abs(point1.Distance(point2) - point1.Distance(point3)) < double.Epsilon ||
                Math.Abs(point1.Distance(point2) - point2.Distance(point3)) < double.Epsilon ||
                Math.Abs(point1.Distance(point3) - point2.Distance(point3)) < double.Epsilon)
                return new IsoscelesTriangle(point1, point2, point3, Colour.blue);
            else return new JustTriangle(point1, point2, point3, Colour.white);
        }
    }
}
