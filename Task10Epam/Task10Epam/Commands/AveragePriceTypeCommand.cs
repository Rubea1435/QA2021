using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class AveragePriceTypeCommand : ICommand
    {
        private string CarBrand;

        public AveragePriceTypeCommand(string carBrand)
        {
            CarBrand = carBrand;
        }

        public void Execute()
        {
            Console.WriteLine(CarDealer.GetInstance().GetAverageAmongTypeBy(x => x.Price, x => x.Brand == CarBrand));
        }
    }
}
