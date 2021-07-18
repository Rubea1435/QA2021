using System;

namespace task3epam
{
    class NumeralSystemsEntryPoint
    {
        static void Main(string[] args)
        {
            int number;
            int numeralSystem;

            if (args.Length < 2)
            {
                Console.WriteLine("Input string is empty. Number and numeral system are required.");
                return;
            }

            bool successParseNumber = int.TryParse(args[0], out number);
            bool successParseNumeralSystem = int.TryParse(args[1], out numeralSystem);

            if (successParseNumber && successParseNumeralSystem)
            {
                try
                {
                    string newNumber = number.ConvertToNumeralSystem(numeralSystem);
                    Console.WriteLine(newNumber);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else Console.WriteLine("Incorrect input value.");
        }
    }
}
