using System;

namespace METHODS_FUNCTIONS_Fundamentals
{
    class Program
    {
        static void PrintSomething (string name)
        {
            int age = 77;
            Console.WriteLine("My name is:" + name + " I am:" + age);
        }
        static void Main()
        {
            PrintSomething("Bay Ivan");
        }
    }
}
