using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class CountAllCommand : ICommand
    {
        private CarDealer _dealer;

        public CountAllCommand(CarDealer dealer)
        {
            _dealer = dealer;
        }

        public void Execute()
        {
            Console.WriteLine(_dealer.GetParkSize());
        }
    }
}
