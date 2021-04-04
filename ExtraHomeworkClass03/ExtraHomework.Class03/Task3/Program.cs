using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            int sum = 1;
            
            while (number != 0)
            {
                sum = sum * (number % 10);
                number = number / 10;
            }

            Console.WriteLine("The total sum of the product of the digits is " + sum);


        }
    }
}
