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
            if (!_park.Select(x => x.ID).Contains(vehicle.ID))
            {
                _park.Add(vehicle);
            }
            else
            {
                throw new AddException("Vehicle with the same ID is already in the park.");
            }
        }

        public int GetCount()
        {
            return _park.Count;
        }

        public List<Vehicle> GetAutoByParameter<T>(Func<Vehicle, T> parameter, T value) where T : IComparable
        {
            return _park.Where(x => parameter(x).CompareTo(value) == 0).ToList();            
        }

        public void UpdateVehicle(int ID, Vehicle newVehicle)
        {
            if (_park.Select(x => x.ID).Contains(ID))
            {
                _park[_park.FindIndex(x => x.ID == ID)] = newVehicle;
            }
            else
            {
                throw new UpdateAutoException("Vehicle with this ID doesn't exist in the park.");

            }
        }

        public void RemoveVehicle(int ID)
        {
            if (_park.Select(x => x.ID).Contains(ID))
            {
                _park.Remove(_park.Where(x => x.ID == ID).First());
            }
            else
            {
                throw new RemoveAutoException("Vehicle with this ID doesn't exist in the park.");
            }
        }
    }
}
