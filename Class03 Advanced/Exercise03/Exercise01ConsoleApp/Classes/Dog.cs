using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01ConsoleApp
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public static void Validate(Dog dog)
        {
            Type d = typeof(Dog);
            if(d.GetProperties().Count() == 3)
            {
                Console.WriteLine("All properties are here");
            }
            else
            {
                Console.WriteLine("Number of properties not valid");
            }

            if(dog.Id < 0)
            {
                Console.WriteLine($"Id: {dog.Id}, is less than 0, it's not valid");
            }
            else
            {
                Console.WriteLine($"Id: {dog.Id} is valid");
            }

            if(dog.Name.Trim().Length > 2)
            {
                Console.WriteLine($"The name {dog.Name} is longer than 2 characters");
            } 
            else
            {
                Console.WriteLine($"The name {dog.Name} is not valid");
            }
        }
    }

}
