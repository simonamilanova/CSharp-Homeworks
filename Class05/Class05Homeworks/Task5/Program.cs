using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSentance = "Hello World";
            Sentance(strSentance);
        }

        static void Sentance(string str)
        {
            char[] charStr = str.ToCharArray();
            for(int i = 0; i < str.Length; i++)
            {
                if(Char.IsLower(charStr[i]))
                {
                    charStr[i] = char.ToUpper(charStr[i]);
                    Console.Write(charStr[i]);

                } else
                {
                    charStr[i] = char.ToLower(charStr[i]);
                    Console.Write(charStr[i]);
                }
            }
            
        }
    }
}
