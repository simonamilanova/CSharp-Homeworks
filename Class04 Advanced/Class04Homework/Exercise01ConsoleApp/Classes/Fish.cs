using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public class Fish : Pet
    {
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override int Age { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The fish name is {Name} is of type {Type} and is {Age} years old and is {Color}");
        }
    }
}
