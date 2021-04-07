using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "The&nbsp;&nbsp;&nbsp; best &nbsp;Lorem&nbsp; Ipsum&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generator in all the&nbsp; sea!&nbsp;&nbsp; Heave this &nbsp; scurvy copyfiller fer yar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; next&nbsp;&nbsp; adventure&nbsp; and cajol yar clients&nbsp;&nbsp; into walking  the plank with  ev'ry layout!&nbsp;&nbsp;&nbsp; Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own the high seas,&nbsp;&nbsp;&nbsp; argh!";
            string word2 = "    Hello there";   
            RemoveExtraSpaces(word2);

        }

        static void RemoveExtraSpaces (string str)
        {
            string word = str.Trim();
            Console.WriteLine(word);
        }
    }
}
