using System;
using Homework.Class07.ClassLibrary.Classes;

namespace Homework.Class07.MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson simona = new SalesPerson("Simona", "Milanova", Role.Manager, 3000, 500);
            Console.WriteLine(simona.GetSalary());
        }
    }
}
