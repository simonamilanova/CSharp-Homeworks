using System;

namespace Bonus.Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthyear");
            int birthYearInput = int.Parse(Console.ReadLine());
            AgeCalculator(birthYearInput);
        }

        static void AgeCalculator (int birthYear)
        {
            DateTime currentDate = DateTime.Today;
            int yearToday = currentDate.Year;

            int age = yearToday - birthYear;
            Console.WriteLine($"You are {age} years old");
        }
    }
}
