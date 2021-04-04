using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num <= 2)
            {
                Console.WriteLine("Please try again and enter another number");
            }

            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                } 
                



            }
        }
    }
}
