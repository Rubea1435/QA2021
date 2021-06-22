using System;

namespace task1epam
{
    public class MaxSymbolsInRowEntryPoint
    {
        static void Main(string[] args)
        {
            string args1 = ""; // test string to check without cmd.exe
            int maxCount = args[0].MaxNotSameSymbolsInRow();
            Console.WriteLine(maxCount);
        }
    }
}
