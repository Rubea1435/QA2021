using System;
using System.Linq;
using System.Text;

namespace task5
{
    class SquareMatrix
    {
        public int Size { get; protected set; }
        protected int[] data;

        public SquareMatrix() { }

        public SquareMatrix(int size)
        {
            Size = size;
            int massiveLength = Size * Size;
            data = new int[massiveLength];
        }

        public virtual int this[int index1, int index2]
        {
            get
            {
                if (index1 > Size || index2 > Size)
                    throw new Exception("Index is more than size of matrix");
                if (index1 < 0 || index2 < 0)
                    throw new Exception("Index is negative");
                return data[index1 * Size + index2];
            }
            set
            {
                if (index1 > Size || index2 > Size)
                    throw new Exception("Index is more than size of matrix");
                if (index1 < 0 || index2 < 0)
                    throw new Exception("Index is negative");
                data[index1 * Size + index2] = value;
            }
                
        }

        public virtual void InitializeRandom(int from, int to)
        {
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    this[i, j] = rnd.Next(from, to);
        }

        private int GetMaxNumberofDigits() // max number of digits in all elements of matrix (for Print formatting)
        {
            int number = 0;
            int element = data.Max();
            while (element != 0)
            {
                element /= 10;
                number++;
            }
            return number;
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                    Console.Write(this[i, j].ToString().PadLeft(GetMaxNumberofDigits()) + " ");
                Console.Write('\n');
            }
        }

        public override string ToString() 
        {
            StringBuilder matrixString = new StringBuilder();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrixString.Append(this[i, j]);
                    matrixString.Append(" ");
                }
                matrixString.Append("\n");
            }
            return matrixString.ToString();
        }
    }
}
