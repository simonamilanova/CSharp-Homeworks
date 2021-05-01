using Exercise01ConsoleApp.Classes;
using System;

namespace Exercise01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Bruno", "brown");
            Dog dog2 = new Dog(2, "Kara", "white");
            Dog dog3 = new Dog(3, "Rex", "black");

            Dog.Validate(dog1);
            Console.WriteLine("=====");

            Dog.Validate(dog2);
            Console.WriteLine("=====");

            Dog.Validate(dog3);
            Console.WriteLine("=====");

            DogShelter.AddDogs(dog1);
            DogShelter.AddDogs(dog2);
            DogShelter.AddDogs(dog3);

            Console.WriteLine("=====");

            DogShelter.PrintAll();

            Console.ReadLine();

        }
    }
}
