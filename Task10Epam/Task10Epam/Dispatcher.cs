using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Epam
{
    public class Dispatcher
    {
        private ICommand _command;

        public void Run(ICommand command)
        {
            _command = command;
            _command?.Execute();
        }
    }
}
