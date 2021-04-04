using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i <= 99; i++)
            {
                string parsedNum = Convert.ToString(i);
                if(parsedNum[0] > parsedNum[1])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
