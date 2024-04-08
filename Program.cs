using System;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj wielkosc macierzy:");
            //int size = int.Parse(Console.ReadLine());

            Matrix matrixA = new Matrix(3,7);
            Matrix matrixB = new Matrix(3,9);
            Console.WriteLine(matrixA);
            Console.WriteLine(matrixB);

            //for (int i = 2; i < 10; i++) {
            //    Matrix matrixC = new Matrix(2, 0);
            //    DateTime startTime = DateTime.Now;

            //    matrixC.Multiply(matrixA, matrixB, i);

            //    DateTime stopTime = DateTime.Now;
            //    TimeSpan roznica = stopTime - startTime;
            //    Console.WriteLine("Czas pracy dla n= :" + i + " watkow:" + roznica.TotalMilliseconds);
            //}
            Matrix matrixC = new Matrix(3,0);
            matrixC.Multiply(matrixA, matrixB, 3);
            Console.WriteLine(matrixC);
        }
    }
}
