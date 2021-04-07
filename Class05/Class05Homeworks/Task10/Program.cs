using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            CountingDownNumbers(num);
        }

        static void CountingDownNumbers (int n)
        {
            int[] numbers = new int[n+1];

            for(int i = n - 1; i >= 0; i--)
            {
                numbers[i] = i;
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
