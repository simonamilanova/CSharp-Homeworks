using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 5)
            {
                Console.WriteLine("Please try again and enter another number");
            }

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

              
            }
        }
    }
}
