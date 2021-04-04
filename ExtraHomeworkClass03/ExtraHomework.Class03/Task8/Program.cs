using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];

           for(int i = 0; i <= arr1.Length; i++)
            {
                Console.WriteLine("Please enter a number for first array");
                int num1 = int.Parse(Console.ReadLine());
               
                arr1[i] = num1;

                if(i == 3)
                {
                    break;
                }
                
            }

            for (int i = 0; i <= arr2.Length; i++)
            {
                Console.WriteLine("Please enter a number for second array");
                int num2 = int.Parse(Console.ReadLine());
                arr2[i] = num2;

                if (i == 3)
                {
                    break;
                }

            }


            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("The arrays are equal");
                }
                else
                {
                    Console.WriteLine("The arrays are not equal");
                }

            }


        }
    }
}
