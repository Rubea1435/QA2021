using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task10Epam;
using System.Collections.Generic;

namespace Task10EpamTest
{
    [TestClass]
    public class CarDealerTest
    {
        static Car car1 = new Car("Volvo", "XC70", 20000);
        static Car car2 = new Car("Lamborghini", "Aventador", 550000);
        static Car car3 = new Car("Volvo", "C30", 5000);
        static List<Car> garage = new List<Car> { car1, car2, car3 };
        static CarDealer dealer = CarDealer.GetInstance();

        [ClassInitialize]
        public static void AddCars(TestContext context)
        {
            foreach (Car car in garage)
            {
                dealer.AddCar(car);
            }
        }

        [TestMethod]
        public void GetAverageByTest()
        {
            double expectedAveragePrice = 575000.0 / 3;
            double avgPrice = dealer.GetAverageBy(x => x.Price);
            Assert.AreEqual(expectedAveragePrice, avgPrice, 1e-6);
        }

        [TestMethod]
        public void GetAverageAmongTypeByTest()
        {
            double expectedAverageVolvoPrice = 12500;
            double avgVolvoPrice = dealer.GetAverageAmongTypeBy(x => x.Price, x => x.Brand.ToLower() == "volvo");
            Assert.AreEqual(expectedAverageVolvoPrice, avgVolvoPrice, 1e-6);
        }

        [TestMethod]
        public void GetNumberOfTest()
        {
            int expectedNumberOfBrands = 2;
            int numberOfBrands = dealer.GetNumberOf(x => x.Brand);
            Assert.AreEqual(expectedNumberOfBrands, numberOfBrands);
        }

        [TestMethod]
        public void GetNumberOfAllTest()
        {
            int expectedNumberOfBrands = 3;
            int numberOfBrands = dealer.GetNumberOf(x => x);
            Assert.AreEqual(expectedNumberOfBrands, numberOfBrands);
        }
    }
}
