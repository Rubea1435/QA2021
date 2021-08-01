using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class CountAllCommand : ICommand
    {
        public CountAllCommand()
        {
        }

        public void Execute()
        {
            Console.WriteLine(CarDealer.GetInstance().GetParkSize());
        }
    }
}
