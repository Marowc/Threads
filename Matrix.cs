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
        int size;

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
        public Matrix(int size)
        {
            this.size=size;
            this.matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.matrix[i, j] = 0;
                }
            }
        }
        public int getSize() { return this.size; }
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
        
    }
}
