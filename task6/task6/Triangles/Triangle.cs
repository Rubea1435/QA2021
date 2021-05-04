using System;

namespace task6
{
    abstract class Triangle
    {
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }
        public enum Colours
        {
            red,
            blue,
            green,
            white
        }
        public Colours Colour { get; }

        public Triangle(Point point1, Point point2, Point point3, Colours colour)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Colour = colour;
        }

        public abstract double Square();
    }
}
