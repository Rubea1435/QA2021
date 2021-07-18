using System;

namespace task1epam
{
    public class MaxSymbolsInRowEntryPoint
    {
        static void Main(string[] args)
        {
            int maxCount = 0;
            try
            {
                maxCount = args[0].CalculateMaxNotSameSymbolsInRow();
                Console.WriteLine(maxCount);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("String is empty.");
            }
        }
    }
}
