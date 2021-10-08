using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Value(a, b));
            
        }
        static double Value(double a, double b)
        {
            double result = Math.Pow(a, b);
            return result;
        }
    }
}
