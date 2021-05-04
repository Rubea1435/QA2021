using System;

namespace task5
{
    class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public DiagonalMatrix (int size) : base()
        {
            Size = size;
            data = new T[size]; // only diagonal elements
        }

        public override T this[int index1, int index2]
        {
            get
            {
                if (index1 > Size || index2 > Size)
                    throw new Exception("Index is more than size of matrix");
                if (index1 < 0 || index2 < 0)
                    throw new Exception("Index is negative");
                if (index1 == index2)
                    return data[index1];
                else return default(T);
            }
            set
            {
                if (index1 > Size || index2 > Size)
                    throw new Exception("Index is more than size of matrix");
                if (index1 < 0 || index2 < 0)
                    throw new Exception("Index is negative");
                if (index1 != index2)
                    throw new Exception("Indexes are not equal");                        
                data[index1] = value;
            }
        }

        // unfortunatelly it doesn't work with generics
        /*public override void InitializeRandom(int from, int to)
        {
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
                    this[i, i] = rnd.Next(from, to);
        }*/
    }
}
