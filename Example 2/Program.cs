using System;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            PerintNumbers(firstNumber, secondNumber);
        }
        static void PerintNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
