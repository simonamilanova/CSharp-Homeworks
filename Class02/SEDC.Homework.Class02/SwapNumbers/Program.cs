using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("First entered number: " + num2);
            Console.WriteLine("Second entered number: " + num1);
        }
    }
}
