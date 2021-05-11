using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class CarDealer
    {
        private List<Car> park = new List<Car>();
        public CarDealer() { }
        public CarDealer(List<Car> park)
        {
            this.park = park;
        }

        public Car this[int index]
        {
            get
            {
                return park[index];
            }
        }

        public void AddCar(Car car)
        {
            park.Add(car);
        }

        public double GetAverage(Func<Car, double> f) 
        {
            double average = 0.0;
            foreach (var car in park)
            {
                average += f(car);
            }
            average /= park.Count;
            return average;
        }

        public int GetCount<T>(Func<Car, T, bool> f, T comparison)
        {
            int amount = 0;
            foreach (var car in park)
            {
                if (f(car, comparison))
                    amount++;
            }
            return amount;
        }

        public int GetCount()
        {
            return park.Count;
        }
    }
}
