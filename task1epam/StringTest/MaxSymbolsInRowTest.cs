using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1epam;

namespace StringTest
{
    [TestClass]
    public class MaxSymbolsInRowTest
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            string strEmpty = String.Empty;
            Assert.AreEqual(0, strEmpty.CalculateMaxNotSameSymbolsInRow());
        }

        [TestMethod]
        public void StringWith3DifferentSymbolsTest()
        {
            string str = "qwe";
            Assert.AreEqual(3, str.CalculateMaxNotSameSymbolsInRow());
        }

        [TestMethod]
        public void StringWith3SameSymbolsTest()
        {
            string str = "eee";
            Assert.AreEqual(1, str.CalculateMaxNotSameSymbolsInRow());
        }

        [TestMethod]
        public void StringWithAlternatingSymbolsTest()
        {
            string str = "121212";
            Assert.AreEqual(6, str.CalculateMaxNotSameSymbolsInRow());
        }

        [TestMethod]
        public void StringWithDifferentSymbolsStartingInsideTheStringTest()
        {
            string str = "qwee1234";
            Assert.AreEqual(5, str.CalculateMaxNotSameSymbolsInRow());
        }
    }
}
