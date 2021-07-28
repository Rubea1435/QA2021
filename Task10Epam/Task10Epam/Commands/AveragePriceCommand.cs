using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class AveragePriceCommand : ICommand
    {
        private CarDealer _dealer;

        public AveragePriceCommand(CarDealer dealer)
        {
            _dealer = dealer;
        }

        public void Execute()
        {
            Console.WriteLine(_dealer.GetAverageBy(x => x.Price));
        }
    }
}
 