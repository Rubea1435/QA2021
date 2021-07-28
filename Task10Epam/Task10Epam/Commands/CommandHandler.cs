using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task10Epam
{
    class CommandHandler
    {
        private static string[] currentCommandLog;

        public static ICommand GetCommand(string command, CarDealer dealer)
        {
            currentCommandLog = Regex.Split(command, @"[\s]+");

            switch (currentCommandLog[0].ToLower())
            {
                case "add":
                    return GetAddCommand(currentCommandLog, dealer);
                case "count":
                    try
                    {
                        if (currentCommandLog[1].ToLower() == "types")
                        {
                            return GetCountTypesCommand(dealer);
                        }
                        else if (currentCommandLog[1].ToLower() == "all")
                        {
                            return GetCountAllCommand(dealer);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect count command.");
                            return null;
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Incorrect count command.");
                        return null;
                    }
                case "average":
                    if (dealer.GetParkSize() == 0)
                    {
                        Console.WriteLine("No cars at the dealer.");
                        return null;
                    }
                    try
                    {
                        if (currentCommandLog[1].ToLower() == "price" && currentCommandLog.Length == 2)
                        {
                            return GetAveragePriceCommand(dealer);
                        }
                        else if (currentCommandLog[1].ToLower() == "price" && currentCommandLog.Length == 3)
                        {
                            return GetAveragePriceTypeCommand(dealer, currentCommandLog[2]);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect average command.");
                            return null;
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Incorrect average command.");
                        return null;
                    }
                case "exit":
                    return new ExitCommand();
                default:
                    Console.WriteLine("Incorrect command.");
                    return null;   
            }
        }

        private static ICommand GetAddCommand(string[] currentCommandLog, CarDealer dealer)
        {
            try
            {
                Car car = new Car(currentCommandLog[1], currentCommandLog[2], Convert.ToInt32(currentCommandLog[4]));
                return new AddCarCommand(dealer, car, Convert.ToInt32(currentCommandLog[3]));
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid car initialization parameters.");
                return null;
            }          
        }

        private static ICommand GetCountTypesCommand(CarDealer dealer)
        {
            return new CountTypesCommand(dealer);
        }

        private static ICommand GetCountAllCommand(CarDealer dealer)
        {
            return new CountAllCommand(dealer);
        }

        private static ICommand GetAveragePriceCommand(CarDealer dealer)
        {
            return new AveragePriceCommand(dealer);
        }

        private static ICommand GetAveragePriceTypeCommand(CarDealer dealer, string carBrand)
        {
            return new AveragePriceTypeCommand(dealer, carBrand);
        }
    }
}
