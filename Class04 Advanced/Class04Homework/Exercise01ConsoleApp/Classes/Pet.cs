using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public abstract class Pet
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract int Age { get; set; }
        public abstract void PrintInfo();
    }
}
