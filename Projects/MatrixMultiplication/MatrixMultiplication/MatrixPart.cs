using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiplication
{
    class MatrixPart
    {
        private int StartRow { get; }
        private int EndRow { get; }
        private MyMatrix A { get; }
        private MyMatrix B { get; }
        private MyMatrix C { get; set; }


        public MatrixPart(int stRow, int endRow, in MyMatrix A, in MyMatrix B, ref MyMatrix C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            StartRow = stRow;
            EndRow = endRow;
        }

        public void CountPart()
        {
            for (int i = StartRow; i < EndRow; i++)
            {
                for (int j = 0; j < B.Rows; j++)
                {
                    for (int k = 0; k < B.Columns; k++)
                    {
                        C.Matrix[i, k] += A.Matrix[i, j] * B.Matrix[j, k];
                    }
                }
            }
        }

    }
}
