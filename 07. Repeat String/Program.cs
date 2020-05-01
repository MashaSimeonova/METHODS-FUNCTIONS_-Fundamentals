using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatingString(input,repeat));
        }
        private static string RepeatingString(string input, int repeat) 
        {
            string result = "";

            for (int i = 0; i < repeat; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
