using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5epam
{
    interface IFlyable
    {
        void FlyTo(Coordinate coord);
        double GetFlyTime(Coordinate coord);
    }
}
