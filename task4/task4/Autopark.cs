using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Autopark
    {
        private List<Vehicle> park;

        public Autopark(List<Vehicle> park)
        {
            this.park = park;
        }

        public string[] GetInfoList()
        {
            string[] allVehicles = new string[park.Count()];
            for (int i = 0; i < park.Count(); i++)
            {
                allVehicles[i] = park[i].GetFullInfo(); // one row-string – one description
            }
            return allVehicles;
        }

    }
}
