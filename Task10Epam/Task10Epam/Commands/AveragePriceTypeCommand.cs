using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class AveragePriceTypeCommand : ICommand
    {
        private CarDealer _dealer;
        private string CarBrand;

        public AveragePriceTypeCommand(CarDealer dealer, string carBrand)
        {
            _dealer = dealer;
            CarBrand = carBrand;
        }

        public void Execute()
        {
            Console.WriteLine(_dealer.GetAverageAmongTypeBy(x => x.Price, x => x.Brand == CarBrand));
        }
    }
}
