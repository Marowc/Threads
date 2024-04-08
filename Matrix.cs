using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    internal class Matrix
    {
        volatile int[,] matrix;
        int size { get; set; }

        public Matrix(int size, int seed)
        {
            this.size = size;
            this.matrix = new int[size, size];
            Random random = new Random(seed);
            int value;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    value = random.Next(1, 10);
                    this.matrix[i, j] = value;
                }
            }
        }
        public override string ToString()
        {
            string display = "";
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    display += matrix[i, j].ToString() + " ";
                }
                display += "\n";
            }
            return display;
        }
        public void RowTimesCol(Matrix matrixA, Matrix matrixB, int row, int col)
        {
            int sum = 0;
            if (matrixA.size == matrixB.size)
            {
                int size = this.size;
                for (int i = 0; i < size; i++)
                {
                    sum += matrixA.matrix[row, i] * matrixB.matrix[i, col];
                }
            }
            this.matrix[row, col] = sum;
            sum = 0;
        }
        public void Multiply(Matrix matrixA, Matrix matrixB, int numOfThreads)
        {
            Thread[] threads = new Thread[numOfThreads];
            int step = this.size / numOfThreads;
            int rest = this.size % numOfThreads;
            int begin = 0, end = 0;

            for ( int n = 0; n < numOfThreads; n++)
            {
                begin = end;
                if (n == numOfThreads - 1) { end += step + rest; }
                else { end += step; }
                Console.WriteLine("nn:" + n + " bb:" + begin + " ee:" + end);
                //Console.WriteLine(n);
                //Console.WriteLine(begin +" "+ end);
                threads[n] = new Thread(() =>
                {
                    int threadBegin = begin;
                    int threadEnd = end;
                    int num = n;
                    for (int i = threadBegin; i < threadEnd; i++)
                    {
                        for (int j = 0; j < this.size; j++)
                        {
                            this.RowTimesCol(matrixA, matrixB, i, j);
                        }
                    }
                    Console.WriteLine("n:" + num + " b:" + threadBegin + " e:" + threadEnd);
                    Console.WriteLine(ToString());
                });
                threads[n].Name = String.Format("Thread: {0}", n);
                //Console.WriteLine(n);
                //Console.WriteLine(begin + " " + end);
                threads[n].Start();
                //threads[n].Join();
            }
            //foreach (Thread x in threads) { Console.WriteLine("Start"); x.Start(); }
            foreach (Thread thread in threads) { thread.Join(); Console.WriteLine("stop"); }
        }
    }
}
