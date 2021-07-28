using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    public class CarDealer
    {
        public static CarDealer instance;
        private List<Car> _park = new List<Car>();

        private CarDealer() { }

        public static CarDealer GetInstance()
        {
            if (instance == null)
                instance = new CarDealer();
            return instance;
        }

        public void AddCar(Car car)
        {
            _park.Add(car);
        }

        /// <summary>
        /// Get average value by parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public double GetAverageBy<T>(Func<Car, T> parameter) where T : struct, IConvertible // where T : IArithmetic
        {
            return _park.Select(x => Double.Parse(parameter(x).ToString())).Average();
        }

        /// <summary>
        /// Get average value by parameter among cars that match the type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double GetAverageAmongTypeBy<T>(Func<Car, T> parameter, Predicate<Car> type) where T : struct, IConvertible // where T : IArithmetic
        {
            return _park.Where(x => type(x)).Select(x => Double.Parse(parameter(x).ToString())).DefaultIfEmpty().Average();
        }

        public int GetNumberOf<T>(Func<Car, T> parameter)
        {
            return _park.Select(x => parameter(x)).Distinct().Count();
        }

        public int GetParkSize()
        {
            return _park.Count;
        }
    }
}
