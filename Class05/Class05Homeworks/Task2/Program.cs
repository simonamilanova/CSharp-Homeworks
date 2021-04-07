using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome");
            string userInput = Console.ReadLine();
            Console.WriteLine(PalindromeOrNot(userInput));
        }

        static bool PalindromeOrNot (string str)
        {
            
            string n = "";
            for(int i = str.Length - 1; i > -1; i--)
            {
                n += str[i];
            }

            if(n.ToLower() == str.ToLower())
            {
                return true;
            } 
            else
            {
                return false;
            }
            
            
        }
    }
}
