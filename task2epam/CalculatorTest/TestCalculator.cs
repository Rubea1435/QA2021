using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using Calculator;
//using Microsoft.Extensions.Configuration;

namespace CalculatorTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void Setup() => Console.WriteLine("Starting TestHelloWorld tests");

        [TestMethod]
        public void TearDown() => Console.WriteLine("TestHelloWorld tests are finished");

        [TestMethod]
        public void OneCanSumPositiveIntegers() => Assert.AreEqual(Calc.Sum(5, 5), 10);

        [TestMethod]
        public void OneCanSumNegativeIntegers() => Assert.AreEqual(Calc.Sum(-5, -5), -10);

        [TestMethod]
        public void OneCanSubstractPositiveIntegers() => Assert.AreEqual(Calc.Substract(5, 5), 0);

        [TestMethod]
        public void OneCanSubstractNegativeIntegers() => Assert.AreEqual(Calc.Substract(-5, -5), 0);

        [TestMethod]
        public void OneCanSubstracPositiveIntegertFromZero() => Assert.AreEqual(Calc.Substract(0, 100), -100);

        [TestMethod]
        public void OneCanSubstracNegativeIntegertFromZero() => Assert.AreEqual(Calc.Substract(0, -100), 99);

        [Ignore]
        [TestMethod]
        public void OneCanDivideByZero() => Assert.AreEqual(Calc.Divide(1, 0), 0);

        /*[TestMethod]
        public void OneCanReadAppConfig()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build().Get<Config>();
            Console.WriteLine($"Browser: {config.BrowserName}");
            Console.WriteLine($"Timeout: {config.TimeoutSeconds}");
        }*/
    }
}
