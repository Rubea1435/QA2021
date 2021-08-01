using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    class AddCarCommand : ICommand
    {
        private Car _car;
        private int _quantity;

        public AddCarCommand(Car car, int quantity)
        {
            _car = car;
            _quantity = quantity;
        }

        public void Execute()
        {
            for (int i = 0; i < _quantity; i++)
            {
                CarDealer.GetInstance().AddCar(_car);
            }
        }
    }
}
