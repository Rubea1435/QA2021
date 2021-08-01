using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class CountTypesCommand : ICommand
    {
        public CountTypesCommand()
        {
        }

        public void Execute()
        {
            Console.WriteLine(CarDealer.GetInstance().GetNumberOf(x => x.Brand));
        }
    }
}
