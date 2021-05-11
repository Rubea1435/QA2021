using System;
using System.Collections.Generic;
using System.Linq;

namespace task7
{
    static class Helper
    {
        public static double GetMax(this CarDealer dealer, Func<Car, double> f)
        {
            List<double> attributeList = new List<double>();
            for (int i = 0; i < dealer.GetCount(); i++)
            {
                attributeList.Add(f(dealer[i]));
            }
            return attributeList.Max();
        }
    }
}
