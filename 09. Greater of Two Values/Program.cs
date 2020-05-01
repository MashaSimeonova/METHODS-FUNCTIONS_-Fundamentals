using System;
using System.Globalization;
namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            if (value == "char")
            {
                char firstDiggit = char.Parse(Console.ReadLine());
                char secondDiggit = char.Parse(Console.ReadLine());
                MaxChar(firstDiggit, secondDiggit);
            }
            else if (value == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                MaxInt(firstNum, secondNum);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                MaxString(firstString, secondString);
            }
        }
        static void MaxChar(char firstDiggit, char secondDiggit)
        {
            if (firstDiggit>secondDiggit)
            {
                Console.WriteLine(firstDiggit);
            }
            else
            {
                Console.WriteLine(secondDiggit);
            }
        }
        static void MaxInt(int firstNum, int secondNum) 
        {
            if (firstNum>secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }
        }
        static void MaxString(string firstString, string secondString)
        {
           
            int compareOrdinal = String.Compare(firstString, secondString, StringComparison.Ordinal);


            if (compareOrdinal < 0)
                Console.WriteLine(secondString);

            else
                Console.WriteLine(firstString);

        }
    }
}
