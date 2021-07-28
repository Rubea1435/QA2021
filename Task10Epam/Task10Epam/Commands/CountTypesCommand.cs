using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class CountTypesCommand : ICommand
    {
        private CarDealer _dealer;

        public CountTypesCommand(CarDealer dealer)
        {
            _dealer = dealer;
        }

        public void Execute()
        {
            Console.WriteLine(_dealer.GetNumberOf(x => x.Brand));
        }
    }
}
