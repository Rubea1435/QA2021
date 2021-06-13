using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3epam
{
    public static class Helper
    {
        /// <summary>
        /// Converts a number to another numeral system
        /// </summary>
        /// <param name="numeralSystem">numeral system</param>
        /// <returns>String number in new numeral system</returns>
        public static string ToNumeralSystem(this int number, int numeralSystem)
        {
            if (numeralSystem > 36)
                throw new ArgumentOutOfRangeException("Numeral system base can't be more than 36.");
            if (numeralSystem < 2)
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
