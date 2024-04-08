using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class ParallelMatrix
    {
        public static Matrix Multiply(Matrix matrixA, Matrix matrixB, int numOfThreads)
        {
            Matrix matrix = new Matrix(matrixA.getSize());
            ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = numOfThreads };
            int step = matrix.getSize() / numOfThreads;
            int rest = matrix.getSize() % numOfThreads;
            int begin = 0, end = 0;

            Parallel.For(0, numOfThreads, opt, i =>
            {
                begin = end;
                if (i == numOfThreads - 1) { end += step + rest; }
                else { end += step; }
                int threadBegin = begin;
                int threadEnd = end;
                for (int ii = threadBegin; ii < threadEnd; ii++)
                {
                    for (int jj = 0; jj < matrix.getSize(); jj++)
                    {
                        matrix.RowTimesCol(matrixA, matrixB, ii, jj);
                    }
                }
            } );

            return matrix;
        }
    }
}
