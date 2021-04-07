using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number the see what year was n years ago");
            int years = int.Parse(Console.ReadLine());
            if(years <= 20)
            {
                PastYears(years);
            } else
            {
                Console.WriteLine("You can't enter a value that large, please try again");
            }
            
        }

        static void PastYears (int n)
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"The current date is {currentDate}");

            DateTime nYears = currentDate.AddYears(-n);
            Console.WriteLine($"The date {n} years ago was {nYears}, the day was the {nYears.Day}th and the year {nYears.Year}");
        }
    }
}
