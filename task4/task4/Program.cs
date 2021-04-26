using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(6.37, "auto", 100, 25);
            Car car = new Car(2.0, "auto", 220, "4x4");
            Motorcycle motorcycle = new Motorcycle(0.25, "auto", 150, true);
            Truck truck = new Truck(10.0, "manual", 120, 5000);
            List<Vehicle> massive = new List<Vehicle>();
            massive.Add(bus);
            massive.Add(car);
            massive.Add(motorcycle);
            massive.Add(truck);
            Autopark autopark = new Autopark(massive);
            foreach (var item in autopark.GetInfoList())
                Console.WriteLine(item); 
        }
    }
}
