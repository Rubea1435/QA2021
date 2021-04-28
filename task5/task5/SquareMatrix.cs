using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class SquareMatrix
    {
        public int Size { get; }
        protected int[] data;

        public SquareMatrix(int size)
        {
            Size = size;
            data = new int[size * size];
            for (int i = 0; i < size * size; i++)
            {
                data[i] = 0;
            }
        }

        public virtual int this[int index1, int index2]
        {
            get
            {
                return data[index1 * Size + index2];
            }
            set
            {
                data[index1 * Size + index2] = value;
            }
        }

        public void InitializeRandom(int from, int to)
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
    }
}
