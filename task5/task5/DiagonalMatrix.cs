using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class DiagonalMatrix : SquareMatrix
    {
        public DiagonalMatrix (int size) : base(size)
        {
            data = new int[size]; // only diagonal elements
        }

        public override int this[int index1, int index2]
        {
            get
            {
                if (index1 == index2)
                    return data[index1];
                else return 0;
            }
            set
            {
                if (index1 == index2)
                {
                    data[index1] = value;
                }
            }
        }
    }
}
