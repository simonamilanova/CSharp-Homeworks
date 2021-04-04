using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;

                }
            }

            Console.WriteLine("The sum is " + sum);
        }
    }
}
