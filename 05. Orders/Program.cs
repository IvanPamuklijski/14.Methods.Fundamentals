using System;

namespace _05._Orders
{
    class Program
    {
        private static bool quanity;

        public static object PrintResult { get; private set; }

        static void Main(string[] args)
        {
            const double COFFEE = 1.50;
            const double WATER = 1.00;
            const double COKE = 1.40 ;
            const double SNACK = 2.00;
            string product = Console.ReadLine();
            double quanity = double.Parse(Console.ReadLine());
            double productPrice = 0;
            switch (product)
            {
                case "coffee":
                    productPrice = COFFEE;
                    Price(productPrice, quanity);
                    break;
                case "water":
                    productPrice = WATER;
                    Price(productPrice, quanity);
                    break;
                case "coke":
                    productPrice = COKE;
                    Price(productPrice, quanity);
                    break;
                default:
                    productPrice = SNACK;
                    Price(productPrice, quanity);
                    break;
            }

        }
        private static void Price(double quanity, double productPrice)
        {
            Console.WriteLine($"{quanity * productPrice:f2}");
        }


    }
}
