using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class AddCarCommand : ICommand
    {
        private CarDealer _dealer;
        private Car _car;
        private int _quantity;

        public AddCarCommand(CarDealer dealer, Car car, int quantity)
        {
            _dealer = dealer;
            _car = car;
            _quantity = quantity;
        }

        public void Execute()
        {
            for (int i = 0; i < _quantity; i++)
            {
                _dealer.AddCar(_car);
            }
        }
    }
}
