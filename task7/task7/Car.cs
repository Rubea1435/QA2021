using System;

namespace task7
{
    class Car
    {
        public CarBrand Brand { get; }
        public string Model { get; }
        public CarBodyType BodyType { get; }
        public CarEngineType EngineType { get; }
        public double EngineSize { get; }    // in litres
        public int Price { get; } // in euros

        public Car(CarBrand brand, string model, CarBodyType bodyType, CarEngineType engineType, double engineSize, int price)
        {
            Brand = brand;
            Model = model;
            BodyType = bodyType;
            EngineType = engineType;
            if (engineSize > 0.0)
                EngineSize = engineSize;
            else throw new ArgumentOutOfRangeException();
            if (price > 0)
                Price = price;
            else throw new ArgumentOutOfRangeException();
        }
    }
}
 