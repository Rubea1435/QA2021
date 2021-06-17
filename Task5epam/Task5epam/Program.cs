using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate start = new Coordinate(0.0, 0.0, 0.0);
            Coordinate finish = new Coordinate(50.0/6, 0.0, 0.0);

            Bird bird = new Bird(start);
            Plane plane = new Plane(start);
            Drone drone = new Drone(start);
            List<IFlyable> aeroItems = new List<IFlyable> { bird, plane, drone };
            foreach (var item in aeroItems)
            {
                if (item is Bird)
                    Console.WriteLine((item as Bird).GetSpeed() + " " + item.GetFlyTime(finish));
                else Console.WriteLine(item.GetFlyTime(finish));
            }
        }
    }
}
