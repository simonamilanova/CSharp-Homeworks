using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            for(int i = 1; i <= 1000; i++)
            {
                for (int sum = 0; i > 0; sum += i % 10, i /= 10)
                {
                    Console.WriteLine(i);
                }
            }
            

            /* Single line that calculates sum */
            
        }
    }
}
