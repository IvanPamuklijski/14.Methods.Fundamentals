using System;

namespace _03.Calculations
{
    class Program
    {
        public static object Add { get; private set; }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "multiply":
                    Multyply(a, b);
                        break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
                case "add":
                    Ad(a, b);
                    break;

            }
        }

        private static void Ad(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        private static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void Multyply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        private static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
