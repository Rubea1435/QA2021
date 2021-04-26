using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void whenStringIsEmpty(string str)
        {
            int maxCount = 1;
            if (string.IsNullOrEmpty(str) == true)
            {
                maxCount = 0;
                Console.WriteLine(maxCount);
                return;
            }
        }

        static int calculateNotSameSymbolsInRow(string str)
        {
            int maxCount = 1;
            int count = 1; // maximum letters in a row on the current iteration 
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                    maxCount = count;
            }
            return maxCount;
        }

        static void Main(string[] args)
        {
            string args1 = ""; // test string to check without cmd.exe
            int maxCount = 1; // maximum at all
            whenStringIsEmpty(args[0]);
            maxCount = calculateNotSameSymbolsInRow(args[0]);            
            Console.WriteLine("\n"+maxCount);
        }
    }
}
