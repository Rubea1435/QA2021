using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; } // in euros

        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}
