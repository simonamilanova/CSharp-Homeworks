using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = "Hello world, hello there";
            string substring = "ll";

            FindSubstring(sentance, substring);

        }

        static void FindSubstring(string str, string subsStr)
        {
            int start = 0;
            int n = -1;
            int index = -1;
            while (start != -1)
            {
                start = str.IndexOf(subsStr, index + 1);
                n += 1;
                index = start;
            }

            Console.WriteLine($"The string {str} occurs {n} times");

        }
    }
}
