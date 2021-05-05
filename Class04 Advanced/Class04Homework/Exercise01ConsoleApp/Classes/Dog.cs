using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public class Dog : Pet
    {
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override int Age { get; set; }
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"The dog's name is {Name} is of type {Type} and is {Age} years old, favourite food is {FavouriteFood} and is a good boi {GoodBoi}");
        }
    }
}
