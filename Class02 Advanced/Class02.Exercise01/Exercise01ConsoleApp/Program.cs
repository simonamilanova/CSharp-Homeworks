using Exercise01ConsoleApp.Classes;
using System;

namespace Exercise01ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher firstTeacher = new Teacher(21, "Ana", "Ana21", "123A", "Math");
            Teacher secondTeacher = new Teacher(20, "Petar", "Petar20", "123P", "Science");

            firstTeacher.PrintUser();
            secondTeacher.PrintUser();

            Console.WriteLine();

            Student firstStudent = new Student(11, "Marko", "M123", "Marko11", 5);
            Student secondStudent = new Student(12, "Sara", "S123", "Sara12", 4);

            firstStudent.PrintUser();
            secondStudent.PrintUser();

            Console.ReadLine();
        }
    }
}
