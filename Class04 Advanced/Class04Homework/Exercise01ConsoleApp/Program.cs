using Exercise01ConsoleApp.Classes;
using Exercise01ConsoleApp.Generics;
using System;

namespace Exercise01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> Dog1 = new PetStore<Dog>();
            PetStore<Dog> Dog2 = new PetStore<Dog>();

            PetStore<Cat> Cat1 = new PetStore<Cat>();
            PetStore<Cat> Cat2 = new PetStore<Cat>();

            PetStore<Fish> Fish1 = new PetStore<Fish>();
            PetStore<Fish> Fish2 = new PetStore<Fish>();

            Dog1.Insert(new Dog() { Name = "Dog1", Age = 5, FavouriteFood = "bacon", GoodBoi = true, Type = "Beagle" });
            Dog2.Insert(new Dog() { Name = "Dog2", Age = 6, FavouriteFood = "meat", GoodBoi = true, Type = "Labrador" });

            Cat1.Insert(new Cat() { Name = "Cat1", Age = 2, IsLazy = true, Type = "Some cat type", LivesLeft = 9 });
            Cat2.Insert(new Cat() { Name = "Cat2", Age = 3, IsLazy = true, Type = "Some cat type3", LivesLeft = 8 });

            Fish1.Insert(new Fish() { Name = "Fish1", Age = 1, Type = "Goldfish", Color = "gold", Size = 2 });
            Fish2.Insert(new Fish() { Name = "Fish2", Age = 2, Type = "Goldfish2", Color = "gold", Size = 3 });

            Dog1.PrintPets();
            Dog2.PrintPets();

            Cat1.PrintPets();
            Cat2.PrintPets();

            Fish1.PrintPets();
            Fish2.PrintPets();

            Dog1.BuyPet("Dog3");
            Cat1.BuyPet("Cat1");

        }
    }
}
