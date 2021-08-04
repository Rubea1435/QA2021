using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3epam;

namespace NumeralSystemTesr
{
    [TestClass]
    public class MaxSymbolsInRowTest
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            string strEmpty = String.Empty;
            Assert.AreEqual(0, strEmpty.CalculateMaxSameLatinLettersInRow());
            Assert.AreEqual(0, strEmpty.CalculateMaxSameDigitsInRow());
        }

        [TestMethod]
        public void OnlyDifferentDigitsTest()
        {
            string str = "123";
            Assert.AreEqual(0, str.CalculateMaxSameLatinLettersInRow());
            Assert.AreEqual(1, str.CalculateMaxSameDigitsInRow());
        }

        [TestMethod]
        public void OnlyDifferentLatinLettersTest()
        {
            string str = "abc";
            Assert.AreEqual(1, str.CalculateMaxSameLatinLettersInRow());
            Assert.AreEqual(0, str.CalculateMaxSameDigitsInRow());
        }

        [TestMethod]
        public void OnlyDifferentNonLatinLettersTest()
        {
            string str = "абв";
            Assert.AreEqual(0, str.CalculateMaxSameLatinLettersInRow());
        }

        [TestMethod]
        public void DigitsAndLatinLettersTest()
        {
            string str = "11zzze3";
            Assert.AreEqual(3, str.CalculateMaxSameLatinLettersInRow());
            Assert.AreEqual(2, str.CalculateMaxSameDigitsInRow());
        }
    }
}
