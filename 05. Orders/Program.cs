using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int numberOfProducts = int.Parse(Console.ReadLine());
            double price = 0;
            Result(product, numberOfProducts, price);
        }

        static void Result(string product, int numberOfProducts, double price)
        {

            switch (product)
            {
                case "coffee":
                    price = numberOfProducts * 1.50;
                    break;
                case "water":
                    price = numberOfProducts * 1.00;
                    break;
                case "coke":
                    price = numberOfProducts * 1.40;
                    break;
                case "snacks":
                    price = numberOfProducts * 2.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
