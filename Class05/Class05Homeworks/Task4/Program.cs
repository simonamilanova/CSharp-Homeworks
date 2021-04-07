using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = "Hello2 there34";
            Console.WriteLine($"The sentance {sentance} has {AmountOfDigits(sentance)} numbers and {AmountOfVowels(sentance)} vowels");
        }

        static int AmountOfDigits (string str)
        {
            int digits = 0;
            foreach(char character in str)
            {
                string ch = character.ToString();
                bool isValidDigit = int.TryParse(ch, out int n);
                if(isValidDigit)
                {
                    digits++;
                }
            }
            return digits;
        }

        static int AmountOfVowels (string str)
        {
            int i = 0;
            foreach(char character in str)
            {
                if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    i++;
                }
            }

            return i;
        }
    }
}
