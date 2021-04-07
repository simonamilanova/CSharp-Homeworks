using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Numbers(nums);
        }

        static void Numbers (int[] arr)
        {
            for(int i = 0; i < arr.Length; i++ )
            {
                if(arr[i] % 2 == 0)
                {
                    arr[i] -= 1;
                } else if (arr[i] % 2 != 0)
                {
                    arr[i] += 1;
                }

                Console.Write(arr[i] + " ");
               
            }
            
        }
    }
}
