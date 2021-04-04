using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Ana", "Petar", "Darko", "Sara", "Stefan" };
            string[] studentsG2 = { "Marija", "Jovan", "Ilina", "Ana", "Marko", "Nikola" };

            Console.WriteLine("Please select group 1 or group 2");
            string num = Console.ReadLine();

            if(num == "1")
            {
                Console.WriteLine("The students in G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }

            if(num == "2")
            {
                Console.WriteLine("The students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
        }
    }
}
