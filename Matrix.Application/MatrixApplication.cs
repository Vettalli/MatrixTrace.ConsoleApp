using System;

namespace Matrix.Application
{
    public class MatrixApplication : IMatrix
    {
        public int[,] MatrixCreation(int a, int b)
        {            
            if (a <= 0 || b <= 0)
            {
                throw new OverflowException("Excpected call to MatrixCreation method failed with OverflowException");
            }

            int[,] matrix = new int[a, b];
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);
                }
            }

            return matrix;
        }

        public int MatrixSum(int[,] matrix)
        {
            int[,] matrixNull = null;

            if (matrix == matrixNull)
            {
                throw new NullReferenceException("Excpected call of MatrixSum method failed with NullReferenceException");
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}

