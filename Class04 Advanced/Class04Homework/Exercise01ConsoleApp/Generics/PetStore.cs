using Exercise01ConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01ConsoleApp.Generics
{
    public class PetStore<T>
        where T : Pet
    {
        public List<T> Pets { get; set; }

        public PetStore()
        {
            Pets = new List<T>();
        }
        public void PrintPets()
        {
            foreach(T item in Pets)
            {
                Console.WriteLine($"Pet's name: {item.Name}");
            }
        }

        public void BuyPet(string name)
        {
            T item = Pets.FirstOrDefault(x => x.Name == name);
            if(item == null)
            {
                Console.WriteLine($"There is no pet by this name: {name}");
            } else
            {
                Console.WriteLine($"The pet {name} has succesfully been bought");
            }
            Pets.Remove(item);
        }

        public void Insert(T item)
        {
            Pets.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
        }
    }
}
