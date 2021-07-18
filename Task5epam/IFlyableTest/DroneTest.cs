using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5epam;

namespace IFlyableTest
{
    [TestClass]
    public class DroneTest
    {
        static Coordinate start = new Coordinate(0.0, 0.0, 0.0);
        Drone drone = new Drone(start);

        // When the distance is more than limit distance 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DistanceLimitExceptionTest()
        {
            Coordinate finish = new Coordinate(1000, 1, 1);
            drone.FlyTo(finish);
        }

        // When the distance is covered with several one-minute freezes, speed is 50 km/h
        [TestMethod]
        public void DroneFlyTimeWithFreezes20KilometersWithSpeed50Test()
        {
            Drone drone = new Drone(start);
            Coordinate finish = new Coordinate(20.0, 0, 0);
            double expectedTime = 26.0/60;
            Assert.AreEqual(expectedTime, drone.GetFlyTime(finish), double.Epsilon);
        }

        // When the trip time is less then the first freeze happens
        [TestMethod]
        public void DroneFlyTimeWithoutFreezesWithSpeed50Test()
        {
            Drone drone = new Drone(start);
            Coordinate finish = new Coordinate(1.0, 2.0, 0);
            double expectedTime = finish.GetDistance(start) / drone.GetSpeed();
            Assert.AreEqual(expectedTime, drone.GetFlyTime(finish), double.Epsilon);
        }

        // When freezes exactly before finish
        [TestMethod]
        public void DroneFlyTimeFreezeBeforeFinishWithSpeed50Test()
        {
            Drone drone = new Drone(start);
            Coordinate finish = new Coordinate(50.0/6, 0, 0);
            double expectedTime = finish.GetDistance(start) / drone.GetSpeed() + 1/60.0;
            Assert.AreEqual(expectedTime, drone.GetFlyTime(finish), double.Epsilon);
        }
    }
}
