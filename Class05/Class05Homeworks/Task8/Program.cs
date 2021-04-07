using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get what day will it be n days from now");
            int days = int.Parse(Console.ReadLine());
            NDaysFromNow(days);
        }

        static void NDaysFromNow (int n)
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"Today's date is {currentDate}");
            
            DateTime nDays = currentDate.AddDays(n);
            Console.WriteLine($"In {n} days the date will be {nDays}");
        }
    }
}
