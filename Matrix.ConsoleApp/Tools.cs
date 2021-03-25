using System;

namespace Matrix.ConsoleApp
{
    public class Tools 
    {
        public static void Display(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(matrix[i, j] + " ");
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
