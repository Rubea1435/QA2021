using System;
using System.Collections.Generic;
using System.Text;

namespace Task5epam
{
    class FlyableEntryPoint
    {
        static void Main(string[] args)
        {
            Coordinate start = new Coordinate(0.0, 0.0, 0.0);
            Coordinate finish = new Coordinate(50.0/6, 0.0, 0.0);

            Bird bird = new Bird(start);
            Plane plane = new Plane(start);
            Drone drone = new Drone(start);
            List<IFlyable> aeroItems = new List<IFlyable> { bird, plane, drone };
            StringBuilder[] resultOutput = new StringBuilder[aeroItems.Count];
            for (int i = 0; i < aeroItems.Count; i++)
            {
                resultOutput[i] = new StringBuilder();
            }

            int index = 0; // row number in string matrix
            foreach (var item in aeroItems)
            {
                if (item is Bird)
                {
                    resultOutput[index].Append((item as Bird).GetSpeed() + " " + item.GetFlyTime(finish));
                }
                else
                {
                    resultOutput[index].Append(item.GetFlyTime(finish));
                }
                index++;
            }
            foreach (StringBuilder info in resultOutput)
            {
                Console.WriteLine(info);
            }
        }
    }
}
