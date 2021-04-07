using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentance");
            string userInput = Console.ReadLine();

            FunWithStrings(userInput);
        }

        static void FunWithStrings(string str)
        {
            //reverse string
            for (int n = str.Length - 1; n >= 0; n--)
            {
                Console.WriteLine(str[n]);
            }

            //total number of vowels
            int i = 0;
            foreach (char character in str)
            {
                str.ToLower().ToCharArray();

                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    i++;

                }

            }

            //is string palindrome 
            string palindrome = "";
            for (int counter = str.Length - 1; counter > -1; counter--)
            {
                palindrome += str[counter];
            }

            if (palindrome.ToLower() == str.ToLower())
            {
                palindrome = "palindrome";
            }
            else
            {
                palindrome = "not a palindrome";
            }

            ////find the largest and smallest word 
            string largestWord = "";
            string smallestWord = "";
            foreach (string word in str.Split())
            {
                if (word.Length > largestWord.Length)
                {
                    largestWord = word;
                }

                if(word.Length < smallestWord.Length)
                {
                    smallestWord = word;
                }
            }

            //find the number of words
            int countWord = 0;
            int numOfWords = 1;

            while (countWord <= str.Length - 1)
            {
                if (str[countWord] == ' ')
                {
                    numOfWords++;
                }

                countWord++;
            }

            Console.WriteLine($"The number of vowels in the string is {i}, the string is {palindrome}");
            Console.WriteLine($"The number of words is {numOfWords}");
            Console.WriteLine($"the largest word is {largestWord} and the smallest word is {smallestWord}");
    
        }
    }
}
