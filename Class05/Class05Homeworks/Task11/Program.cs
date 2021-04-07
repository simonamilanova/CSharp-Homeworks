using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 4, 1, 4, -10, -50, 32, 21 };
            BiggestAndSmallestNumber(numbers);
        }

        static void BiggestAndSmallestNumber (int[] arr)
        {
            int biggestNum = arr[0];
            int smallestNum = arr[0];
           for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > biggestNum)
                {
                    biggestNum = arr[i];
                }

                if(arr[i] < smallestNum)
                {
                    smallestNum = arr[i];
                }
            }
            Console.WriteLine($"The biggest number is {biggestNum}");
            Console.WriteLine($"The smallest number is {smallestNum}");
        }
    }
}
