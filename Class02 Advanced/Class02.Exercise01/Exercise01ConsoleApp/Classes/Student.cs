using Exercise01ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01ConsoleApp.Classes
{
    public class Student : User, IStudent
    {
        public Student (int id, string name, string username, string password, int grades)
            :base(id, name, username, password)
        {
            Grades = grades;
        }
        public int Grades { get; set; }
        public override void PrintUser()
        {
            Console.WriteLine($"The student grade is: {Grades}");
        }
    }
}
