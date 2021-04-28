using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            SquareMatrix squareMatrix = new SquareMatrix(size);
            squareMatrix.InitializeRandom(0, 50);
            squareMatrix.Print();

            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(size);
            diagonalMatrix.InitializeRandom(0, 20);
            Console.WriteLine();
            diagonalMatrix.Print();
        }
    }
}
