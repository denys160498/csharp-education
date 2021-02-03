using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixMultiplication
{
    class MyMatrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int[,] Matrix { get; private set; }

        public MyMatrix(int[,] matr)
        {
            Matrix = matr;
            Rows = matr.GetUpperBound(0) + 1;
            Columns = matr.Length / Rows;
        }

        public MyMatrix(int r, int c)
        {
            Matrix = new int[r, c];
            Rows = r;
            Columns = c;
        }

        public static MyMatrix operator +(MyMatrix A, MyMatrix B)
        {
            if (A.Rows != B.Rows || A.Columns != B.Columns)
            {
                throw new InvalidOperationException();
            }

            MyMatrix C = new MyMatrix(A.Rows, A.Columns);

            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Columns; j++)
                {
                    C.Matrix[i, j] = A.Matrix[i, j] + B.Matrix[i, j];
                }
            }

            return C;
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                string row = "";
                for (int j = 0; j < Columns; j++)
                {
                    row += Matrix[i, j].ToString() + " ";
                }
                Console.WriteLine(row);
            }
        }
    }
}
