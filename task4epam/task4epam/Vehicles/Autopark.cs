using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4epam
{
    public class Autopark 
    {
        private List<Vehicle> _park = new List<Vehicle>();

        public Autopark() { }
        public Autopark(List<Vehicle> park)
        {
            _park = park;
        }

        public Vehicle this[int index]
        {
            get
            {
                return _park[index];
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _park.Add(vehicle);
        }

        public int GetCount()
        {
            return _park.Count;
        }

        public List<Vehicle> GetAutoByParameter<T>(Func<Vehicle, T> parameter, T value) where T : IComparable
        {
            return _park.Where(x => parameter(x).CompareTo(value) == 0).ToList();            
        }
    }
}
