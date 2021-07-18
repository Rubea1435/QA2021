using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    public class Bird : IFlyable
    {
        public Coordinate CurrentPosition { get; private set; } // positive kilometers  

        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Changes current position to new
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            CurrentPosition = newCoordinate;
        }

        /// <summary>
        /// Bird flies full distance at a constant speed in the range of 0-20 km/h (set randomly).
        /// </summary>
        /// <returns></returns>
        public int GetSpeed()
        {
            Random rnd = new Random();
            int speed = rnd.Next(0, 20); // km/h
            return speed;
        }

        /// <summary>
        /// Time to get to new coordinate by bird.
        /// </summary>
        /// <param name="newCoordinate">Another point</param>
        /// <returns>Fly time to get to another point</returns>
        public double GetFlyTime(Coordinate newCoordinate)
        {
            double time = CurrentPosition.GetDistance(newCoordinate) / GetSpeed(); // hours
            return time;
        }
    }
}
