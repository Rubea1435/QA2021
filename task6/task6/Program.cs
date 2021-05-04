using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0.0, 0.0);
            Point point2 = new Point(2.0, 0.0);
            Point point3 = new Point(2.1, 3.1);

            TriangleBuilder triangleBuilder = new TriangleBuilder();
            Triangle certainTriangle = triangleBuilder.CreateTriangle(point1, point2, point3);
            Console.WriteLine("That's a " + certainTriangle.GetType().ToString() +
                " square = " + certainTriangle.Square() + " colour = " + certainTriangle.Colour);
        }
    }
}
