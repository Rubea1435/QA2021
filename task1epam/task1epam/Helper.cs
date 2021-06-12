namespace task1epam
{
    public static class Helper
    {
        /// <summary>
        /// Calculates maximum number of not the same symbols in string in a row
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int MaxNotSameSymbolsInRow(this string str)
        {
            int maxCount = 1; // maximum at all
            int count = 1; // maximum letters in a row on the current iteration 

            if (string.IsNullOrEmpty(str))
                maxCount = 0;

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
    }
}
