using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5epam;

namespace IFlyableTest
{
    [TestClass]
    public class CoordinateTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoordinateRangeExceptionTest()
        {
            Coordinate negativeCoordinate = new Coordinate(-1, 1, 0);
        }
    }
}
