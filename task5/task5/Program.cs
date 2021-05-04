using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            SquareMatrix<double> squareMatrix = new SquareMatrix<double>(size);
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    squareMatrix[i, j] = rnd.NextDouble();

            string str1 = squareMatrix.ToString();
            Console.Write(str1);            

            DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(size);
            try
            {
                for (int i = 0; i < size; i++)
                    diagonalMatrix[i, i] = rnd.Next(0, 10);
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }
            Console.WriteLine();
            string str2 = diagonalMatrix.ToString();
            Console.Write(str2);
        }
    }
}
