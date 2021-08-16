using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task10Epam
{
    public static class CommandHandler
    {
        private static string[] currentCommandLog;

        public static ICommand GetCommand(string command)
        {
            currentCommandLog = Regex.Split(command, @"[\s]+");

            switch (currentCommandLog[0].ToLower())
            {
                case "add":
                    return GetAddCommand(currentCommandLog);
                case "count":
                    try
                    {
                        if (currentCommandLog[1].ToLower() == "types")
                        {
                            return GetCountTypesCommand();
                        }
                        else if (currentCommandLog[1].ToLower() == "all")
                        {
                            return GetCountAllCommand();
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
                    if (CarDealer.GetInstance().GetParkSize() == 0)
                    {
                        Console.WriteLine("No cars at the dealer.");
                        return null;
                    }
                    try
                    {
                        if (currentCommandLog[1].ToLower() == "price" && currentCommandLog.Length == 2)
                        {
                            return GetAveragePriceCommand();
                        }
                        else if (currentCommandLog[1].ToLower() == "price" && currentCommandLog.Length == 3)
                        {
                            return GetAveragePriceTypeCommand(currentCommandLog[2]);
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

        private static ICommand GetAddCommand(string[] currentCommandLog)
        {
            try
            {
                Car car = new Car(currentCommandLog[1], currentCommandLog[2], Convert.ToInt32(currentCommandLog[4]));
                return new AddCarCommand(car, Convert.ToInt32(currentCommandLog[3]));
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid car initialization parameters.");
                return null;
            }          
        }

        private static ICommand GetCountTypesCommand()
        {
            return new CountTypesCommand();
        }

        private static ICommand GetCountAllCommand()
        {
            return new CountAllCommand();
        }

        private static ICommand GetAveragePriceCommand()
        {
            return new AveragePriceCommand();
        }

        private static ICommand GetAveragePriceTypeCommand(string carBrand)
        {
            return new AveragePriceTypeCommand(carBrand);
        }
    }
}
