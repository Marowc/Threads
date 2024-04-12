using System;
using System.Data;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 500;
            int numOfMaxThreads = 10;
            int repeat = 10;

            for (int numOfThreads = 1; numOfThreads < numOfMaxThreads; numOfThreads++) {

                double sumOfThreadTime = 0;
                double sumOfParallelTime = 0;

                Console.WriteLine("Thread");
                Console.WriteLine("size: \t numOfThreads: \t time:");
                for (int i = 0; i < repeat; i++)
                {
                    Matrix matrixA = new Matrix(size, 7);
                    Matrix matrixB = new Matrix(size, 9);
                    Matrix matrixC = new Matrix(size);

                    DateTime startThreadTime = DateTime.Now;
                    matrixC = ThreadMatrix.Multiply(matrixA, matrixB, numOfThreads);
                    DateTime stopThreadTime = DateTime.Now;

                    TimeSpan ThreadTime = stopThreadTime - startThreadTime;
                    //Console.WriteLine("Czas pracy Threads dla n " + numOfThreads + " watkow: " + ThreadTime.TotalMilliseconds + " ms, wielkosc macierzy size = " + size);
                    Console.WriteLine(size + "\t" + numOfThreads + "\t" + ThreadTime.TotalMilliseconds);
                    sumOfThreadTime += ThreadTime.TotalMilliseconds;
                }
                Console.WriteLine("average = " + sumOfThreadTime / repeat + " ms");

                Console.WriteLine("Parallel");
                Console.WriteLine("size: \t numOfThreads: \t time:");
                for (int i = 0; i < repeat; i++) {
                    Matrix matrixA = new Matrix(size, 7);
                    Matrix matrixB = new Matrix(size, 9);
                    Matrix matrixD = new Matrix(size);

                    DateTime startParallelTime = DateTime.Now;
                    matrixD = ParallelMatrix.Multiply(matrixA, matrixB, numOfThreads);
                    DateTime stopParallelTime = DateTime.Now;

                    TimeSpan ParallelTime = stopParallelTime - startParallelTime;
                    //Console.WriteLine("Czas pracy Parallel dla n " + numOfThreads + " watkow: " + ParallelTime.TotalMilliseconds + " ms, wielkosc macierzy size = " + size);
                    Console.WriteLine(size + "\t" + numOfThreads + "\t" + ParallelTime.TotalMilliseconds);
                    sumOfParallelTime += ParallelTime.TotalMilliseconds;
                }
                Console.WriteLine("average = " + sumOfParallelTime / repeat + " ms");

            }
        }
    }
    }

