using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        //public delegate double MyFunc(Car item);
        public static double GetPrice(Car item) { return item.Price; }
        public static double GetEngineSize(Car item) { return item.EngineSize; }
        public static bool IsPriceLess(Car item, int price) { return item.Price < price; }
        public static bool IsBrand(Car item, CarBrand brand) { return item.Brand == brand; }
        public static bool IsModel(Car item, string model) { return item.Model == model; }

        static void Main(string[] args)
        {
            Car automobile1 = new Car(CarBrand.LandRover, "Defender", CarBodyType.pickup, CarEngineType.diesel, 2.2, 14001);
            Car automobile2 = new Car(CarBrand.Lamborghini, "Aventador", CarBodyType.supercar, CarEngineType.petrol, 6.5, 250000);
            CarDealer AtlantM = new CarDealer();
            AtlantM.AddCar(automobile1);
            AtlantM.AddCar(automobile2);
            Console.WriteLine(AtlantM[0].Brand); // indexator testing, to make list of cars private

            Func<Car, double> f1 = GetEngineSize;
            double averageEngineSize = AtlantM.GetAverage(f1);
            double averagePrice = AtlantM.GetAverage(GetPrice); // without explicit delegate
            Console.WriteLine("average engine size: " + averageEngineSize);
            Console.WriteLine("average price: " + averagePrice);

            Func<Car, CarBrand, bool> f2 = IsBrand; 
            int landRoverAmount = AtlantM.GetCount<CarBrand>(f2, CarBrand.LandRover);
            int limitPrice = 3000;
            int cheapCarsAmount = AtlantM.GetCount(IsPriceLess, limitPrice); // without explicit delegate
            int allAmount = AtlantM.GetCount();
            Console.WriteLine("quantity of Land Rovers: " + landRoverAmount);
            Console.WriteLine("quantity of cars cheaper than {0}: " + cheapCarsAmount, limitPrice);
            Console.WriteLine("quantity of all items: " + allAmount);

            double maxEngineSize = AtlantM.GetMax(f1);
            int maxPrice = (int)AtlantM.GetMax(GetPrice);
            Console.WriteLine("maximum engine size: " + maxEngineSize);
            Console.WriteLine("maximum price: " + maxPrice);
        }
    }
}
