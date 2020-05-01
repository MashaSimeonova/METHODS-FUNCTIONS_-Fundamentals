using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFigure(n);
        }
        static void PrintLine(int row)
        {
            for (int colm = 1; colm <= row; colm++)
            {
                Console.Write(colm + " ");
            }
            Console.WriteLine();
        }
        static void PrintFigure(int n) 
        {
            for (int row = 1; row <= n; row++)
            {
                PrintLine(row);
            }
            for (int row = n-1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }
    }
}
