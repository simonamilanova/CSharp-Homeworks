using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + " is " + result);
        }
    }
}
