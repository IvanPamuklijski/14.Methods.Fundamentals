using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat = RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(repeat);



        }
        static string RepeatString(string value, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += value;
            }
                return result;
        }

      
    }
}
