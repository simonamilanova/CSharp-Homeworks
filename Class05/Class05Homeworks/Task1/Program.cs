using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            NumberStats(num);
        }

        static void NumberStats(int number)
        {
            int n = number;
 
            int digits = 0;
            while (n != 0)
            {
                digits++;
                n = n / 10;
            }
       
            string evenOrOdd = "";
            if(number % 2 == 0)
            {
                evenOrOdd = "even";
            } else
            {
                evenOrOdd = "odd";
            }

            string positiveOrNegative = "";
            if(number > 0)
            {
                positiveOrNegative = "positive";   
            } else
            {
                positiveOrNegative = "negative";
            }

            Console.WriteLine($"The number {number} has {digits} digits, it is a {positiveOrNegative} number and is {evenOrOdd}.");
        }
    }
}
