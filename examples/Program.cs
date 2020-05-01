using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = -4;
            int sqaureOfA = numberA * numberA;

            int product = GetSqaureAria (numberA);
            Console.WriteLine(product);
        }
        static int GetSqaureAria(int inputValue)
        {
           var Negative = isNegative(inputValue);
            return inputValue * inputValue;
        }
        static bool isNegative(int inputParameter)
        {
            if (inputParameter<0)
            {
                return true;
            }
            return false;
        }
    }
}
