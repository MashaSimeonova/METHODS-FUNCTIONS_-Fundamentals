using System;

namespace _11._Math_operations
{
    class Program
    {
       public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char command = char.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, command, secondNumb);
            PrintResult(result);

        }
       private static double Calculate(int firstNum, char command, int seconNumb)
        {
            double result = 0;
            switch (command)
            {
                case '+':
                    result = (double)firstNum + (double)seconNumb;
                    break;
                case '-':
                    result = (double)firstNum - (double)seconNumb;
                    break;
                case '*':
                    result = (double)firstNum * (double)seconNumb;
                    break;
                case '/':
                    result = (double)firstNum / (double)seconNumb;
                    break;
                default:
                    break;
            }
           
            return result;
            
        }
        static void PrintResult(double result)
        {
            string numberAsString = result.ToString();
            if (numberAsString.Contains('.'))
            {
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine(result);
            }
        }


    }
}

