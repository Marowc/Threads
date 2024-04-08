using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class ThreadMatrix
    {
        public static Matrix Multiply(Matrix matrixA, Matrix matrixB, int numOfThreads)
        {
            Matrix matrix = new Matrix(matrixA.getSize());
            Thread[] threads = new Thread[numOfThreads];
            int step = matrix.getSize() / numOfThreads;
            int rest = matrix.getSize() % numOfThreads;
            int begin = 0, end = 0;

            for (int n = 0; n < numOfThreads; n++)
            {
                begin = end;
                if (n == numOfThreads - 1) { end += step + rest; }
                else { end += step; }
                int threadBegin = begin;
                int threadEnd = end;
                threads[n] = new Thread(() =>
                {
                    for (int i = threadBegin; i < threadEnd; i++)
                    {
                        for (int j = 0; j < matrix.getSize(); j++)
                        {
                            matrix.RowTimesCol(matrixA, matrixB, i, j);
                        }
                    }
                });
            }
            foreach (Thread thread in threads) thread.Start();
            foreach (Thread thread in threads) thread.Join();

            return matrix;
        }
    }
}
