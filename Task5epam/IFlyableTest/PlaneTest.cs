using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5epam;

namespace IFlyableTest
{
    [TestClass]
    public class PlaneTest
    {
        static Coordinate start = new Coordinate(0.0, 0.0, 0.0);
        Plane plane = new Plane(start);

        // When the distance is a multiple of distances with constant speed
        [TestMethod]
        public void PlaneFlyTimeLongFlightFullSegmentsTest()
        {
            Coordinate finish = new Coordinate(40.0, 40.0, 20.0);
            double expectedTime = 1/20.0 + 1/21.0 + 1/22.0 + 1/23.0 + 1/24.0 + 1/25.0;
            Assert.AreEqual(expectedTime, plane.GetFlyTime(finish), double.Epsilon);
        }

        // When the distance is NOT a multiple of distances with constant speed 
        [TestMethod]
        public void PlaneFlyTimeLongFlightPartialSegmentsTest()
        {
            Coordinate finish = new Coordinate(18.0, 0, 0);
            double expectedTime = 1 / 20.0 + 8 / 210.0;
            Assert.AreEqual(expectedTime, plane.GetFlyTime(finish), double.Epsilon);
        }

        // When the distance is less then a distance before the first speed increase
        [TestMethod]
        public void PlaneFlyTimeShortFlightTest()
        {
            Coordinate finish = new Coordinate(4.0, 4.0, 2.0);
            double expectedTime = finish.GetDistance(start) / 200.0;
            Assert.AreEqual(expectedTime, plane.GetFlyTime(finish), double.Epsilon);
        }


    }
}
