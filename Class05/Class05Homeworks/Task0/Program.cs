using System;

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine("The final result is " + CalculateNumbers(number, power));
        }

        static int CalculateNumbers (int number, int power)
        {
            int result = 1;
            for(int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
