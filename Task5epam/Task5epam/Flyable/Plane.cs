using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    public class Plane : IFlyable
    {
        public Coordinate CurrentPosition { get; private set; }

        public Plane(Coordinate currentPosition)
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
        /// Plane increases speed by 10 km/h every 10 km of flight from the start speed of 200 km/h.
        /// </summary>
        /// <param name="newCoordinate">Another point</param>
        /// <returns>Fly time to get to another point</returns>
        public double GetFlyTime(Coordinate newCoordinate)
        {
            int startSpeed = 200; // km/h
            int speedIncrease = 10; // km/h
            int speedIncrementDistance = 10; // kilometers  
            double distance = CurrentPosition.GetDistance(newCoordinate); // kilometers
            int increasesNumber = (int)Math.Floor(distance / speedIncrementDistance); // how many times speed increases

            double time = 0;
            double currentSpeed = startSpeed;
            if (increasesNumber > 0)
            {
                for (int i = 1; i <= increasesNumber; i++)
                {
                    time += speedIncrementDistance / currentSpeed;
                    currentSpeed += speedIncrease;
                }
                double lastSegmentLength = distance % speedIncrementDistance; // kilometers
                time += lastSegmentLength / currentSpeed;
            }
            else time = distance / startSpeed;
            
            return time;
        }
    }
}
