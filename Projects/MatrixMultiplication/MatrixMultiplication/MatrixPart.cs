using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiplication
{
    class MatrixPart
    {
        private int ARowNumber { get; }
        private int BColumnNumber { get; }
        private MyMatrix A { get; }
        private MyMatrix B { get; }
        private MyMatrix C { get; set; }


        public MatrixPart(int aRowNum, int bColNum, ref MyMatrix A, ref MyMatrix B, ref MyMatrix C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            ARowNumber = aRowNum;
            BColumnNumber = bColNum;
        }

        public void CountPart()
        {
            for (int i = 0; i < A.Columns; i++)
            {
                C.Matrix[ARowNumber,BColumnNumber] += A.Matrix[ARowNumber, i] * B.Matrix[i, BColumnNumber];
            }
        }

    }
}
