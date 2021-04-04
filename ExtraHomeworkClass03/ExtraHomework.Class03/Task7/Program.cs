using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letterArr = { "a", "b", "c", "d" };

            for(int i = letterArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(letterArr[i]);
            }
        }
    }
}
