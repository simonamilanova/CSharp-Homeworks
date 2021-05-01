using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog> { };
        }

        public static void PrintAll()
        {
            Console.WriteLine("All the dogs in the list are: ");
            foreach(Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Name}");
            }
        }

        public static void AddDogs(Dog dog)
        {
            Dogs.Add(dog);
        }
    }
}
