using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3epam
{
    public static class StringExtensions
    {
        private static int CalculateMaxSameSymbolsInRow(string str, Predicate<char> symbolCondition)
        {
            int maxCount = 0; // maximum at all
            int count = 0; // maximum letters in a row on the current iteration 

            if (string.IsNullOrEmpty(str))
                return maxCount = 0;

            if (symbolCondition(str[0]))
            {
                maxCount = count = 1;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (symbolCondition(str[i]))
                {
                    if (str[i] == str[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                }
                else
                {
                    count = 0;
                }
                if (count > maxCount)
                    maxCount = count;
            }
            return maxCount;
        }

        public static int CalculateMaxSameLatinLettersInRow(this string str)
        {
            return CalculateMaxSameSymbolsInRow(str, x => (x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z'));
        }

        public static int CalculateMaxSameDigitsInRow(this string str)
        {
            return CalculateMaxSameSymbolsInRow(str, x => (x >= '0' && x <= '9'));
        }
    }
}
