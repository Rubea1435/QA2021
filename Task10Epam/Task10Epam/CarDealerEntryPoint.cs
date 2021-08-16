using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Task10Epam
{
    class CarDealerEntryPoint
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            CarDealer dealer = CarDealer.GetInstance();

            while(true)
            {
                string consoleCommand = Console.ReadLine();
                ICommand nextCommand = CommandHandler.GetCommand(consoleCommand);
                dispatcher.Run(nextCommand);
            }
        }
    }
}
