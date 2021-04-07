using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckForAplhabetChar('A');
            CheckForAplhabetChar('c');
            CheckForAplhabetChar('*');
        }

        static void CheckForAplhabetChar (char character)
        {
            if (Char.IsLetter(character))
            {
                if (Char.IsLower(character))
                {
                    Console.WriteLine($"The character {character} is lower case");
                }
                else
                {
                    Console.WriteLine($"The character {character} is upper case");
                }
            }
            else
            {
                Console.WriteLine("Character is not an alphabet letter");
            }

        }
    }
}
