using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            for (int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;

                int sum = 0;
                for(int n = 0; n < numbers.Length; n++)
                {
                    if(numbers[n] % 2 == 0)
                    {
                        sum += numbers[n];
                    } else
                    {
                        continue;
                        
                    }
 
                }

                if(i == 5)
                {
                    Console.WriteLine("Program has ended");
                    break;
                }

                Console.WriteLine("The result is " + sum);
            }
        }
    }
}
