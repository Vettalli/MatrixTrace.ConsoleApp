using System;
using Matrix.Application;

namespace Matrix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMatrix matrixEx = new MatrixApplication();
            
            Console.WriteLine("Please, write the number of rows and columns");
            int a = 0;
            int b = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunately you have written inappropriate symbols!\nPlease, write integer numbers next time.");
            }
           
            int[,] matrix = new int[,] { };
            int sum=0;
            
            try
            {
                matrix = matrixEx.MatrixCreation(a, b);
                sum = matrixEx.MatrixSum(matrix);
            }
            catch (OverflowException) when(a <= 0 || b <= 0)
            {
                Console.WriteLine("Unfortunately you have writen numbers that out of range");
            }
            catch(NullReferenceException) when (matrix == null)
            {
                Console.WriteLine("Unfortunately you have inappropriate matrix value\nMatix can not be null");
            }

            Tools.Display(matrix);
            Console.WriteLine($"The sum of the main diagonal - {sum}");

            Console.ReadKey();
        }
    }
}
