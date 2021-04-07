using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = { 1, 22, 31, 12, 2, 8 };
            Console.WriteLine($"The biggest number is {BiggestNumber(numbersArr)}");
        }

        static int BiggestNumber (int[] arr)
        {
            int biggestNumber = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > biggestNumber)
                {
                    biggestNumber = arr[i];
                }
            }
            return biggestNumber;
        }
    }
}
