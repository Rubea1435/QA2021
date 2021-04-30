using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            SquareMatrix squareMatrix = new SquareMatrix(size);
            squareMatrix.InitializeRandom(0, 50);
            string str1 = squareMatrix.ToString();
            Console.Write(str1);            

            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(size);
            try
            {
                diagonalMatrix.InitializeRandom(0, 20);
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
