using System;
using System.Text;

namespace task3epam
{
    public static class Helper
    {
        /// <summary>
        /// Extension method for integers that converts a number to another numeral system
        /// </summary>
        /// <param name="numeralSystem">numeral system</param>
        /// <returns>String number in new numeral system</returns>
        public static string ToNumeralSystem(this int number, int numeralSystem)
        {
            int maxNumSystemLimitValue = 36;
            int minNumSystemLimitValue = 2;
            if (numeralSystem > maxNumSystemLimitValue)
                throw new ArgumentOutOfRangeException("Numeral system base can't be more than 36.");
            if (numeralSystem < minNumSystemLimitValue)
                throw new ArgumentOutOfRangeException("Incorrect value of numeral system.");
            if (number < 0)
                throw new ArgumentOutOfRangeException("Number should be positive.");
            int remainder = number;
            StringBuilder result = new StringBuilder();
            while (remainder != 0)
            {
                int numberAfterDivision = remainder % numeralSystem;
                if (numberAfterDivision < 10)
                    result.Insert(0, numberAfterDivision); // appending at start
                else result.Insert(0, Convert.ToChar(numberAfterDivision + 55)); // non-numeric symbol
                remainder /= numeralSystem;
            }
            return result.ToString();
        }
    }
}
