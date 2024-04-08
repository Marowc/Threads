using System;
using System.Data;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 1000;
            int numOfThreads = 2;
            int repeat = 10;
            Matrix matrixA = new Matrix(size,7);
            Matrix matrixB = new Matrix(size,9);
            Matrix matrixC = new Matrix(size);
            Matrix matrixD = new Matrix(size);

            //Console.WriteLine(matrixA);
            //Console.WriteLine(matrixB);

            DateTime startThreadTime = DateTime.Now;
                matrixC = ThreadMatrix.Multiply(matrixA, matrixB, numOfThreads);
                DateTime stopThreadTime = DateTime.Now;

                TimeSpan ThreadTime = stopThreadTime - startThreadTime;
                Console.WriteLine("Czas pracy Threads dla n " + numOfThreads + " watkow:" + ThreadTime.TotalMilliseconds + " ms");
                //Console.WriteLine(matrixC);

                DateTime startParallelTime = DateTime.Now;
                matrixD = ParallelMatrix.Multiply(matrixA, matrixB, numOfThreads);
                DateTime stopParallelTime = DateTime.Now;

                TimeSpan ParallelTime = stopParallelTime - startParallelTime;
                Console.WriteLine("Czas pracy Parallel dla n " + numOfThreads + " watkow:" + ParallelTime.TotalMilliseconds + " ms");
                //Console.WriteLine(matrixC);
            
        }
    }
    }

