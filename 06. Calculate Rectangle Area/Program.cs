using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, length);
            Console.WriteLine(area);
            
        }

        private static double GetRectangleArea(double width,double length)
        {
            return width * length;
        }
    }
}
