using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3epam;

namespace NumeralSystemTest
{
    [TestClass]
    public class NumeralSystemConverterTest
    {
        [TestMethod]
        public void To2System()
        {
            int number = 8;
            Assert.AreEqual("1000", number.ToNumeralSystem(2));          
        }

        [TestMethod]
        public void ToNumeralSystemWithLetters()
        {
            int number = 27;
            Assert.AreEqual("1D", number.ToNumeralSystem(14));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ToOutOfRangeSystem()
        {
            int number = 8;
            number.ToNumeralSystem(37);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeNumber()
        {
            int number = -8;
            number.ToNumeralSystem(2);
        }
    }
}
