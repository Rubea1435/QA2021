using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    public class Drone : IFlyable
    {
        public Coordinate CurrentPosition { get; private set; }

        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        /// <summary>
        /// Changes current position to new
        /// </summary>
        /// <param name="newCoordinate"></param>
        public void FlyTo(Coordinate newCoordinate)
        {
            double distance = CurrentPosition.GetDistance(newCoordinate);
            if (distance < LimitDistance())
                CurrentPosition = newCoordinate;
            else throw new ArgumentException($"Distance can't be more than {LimitDistance()} kilometers");
        }

        /// <summary>
        /// Maximum distance that a drone can overcome
        /// </summary>
        /// <returns></returns>
        private int LimitDistance()
        {
            return 1000;
        }

        public int GetSpeed()
        {
            return 50;
        }

        /// <summary>
        /// Drone hovers in the air every 10 minutes of flight for 1 minute
        /// </summary>
        /// <param name="newCoordinate">Another point</param>
        /// <returns>Fly time to get to another point</returns>
        public double GetFlyTime(Coordinate newCoordinate)
        {
            int speed = GetSpeed(); // km/h
            double freezePeriod = 1 / 6.0; // hours
            double freezeDuration = 1 / 60.0; // hours 
            double distance = CurrentPosition.GetDistance(newCoordinate); // full trip distance, kilometers
            double distanceInFreezePeriod = speed * freezePeriod; // distance that drone covers during every period before freeze

            double time;
            int freezesNumber = (int)Math.Floor(distance / distanceInFreezePeriod); // how many times freezes during the trip
            if (freezesNumber > 0)
            {
                double partialDistance = distanceInFreezePeriod * freezesNumber; // distance covered in full periods (fly + freeze)
                double avgSpeed = speed * freezePeriod / (freezePeriod + freezeDuration); // while flying with freezing
                time = partialDistance / avgSpeed;
                double lastSegmentLength = distance % partialDistance; // distance to cover without freezes
                time += lastSegmentLength / speed;
            }
            else time = distance / speed;
            return time;
        }
    }
}
