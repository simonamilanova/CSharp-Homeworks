using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class07.ClassLibrary.Classes
{
    public class Employee
    {
        public Employee(string firstName, string lastName, Role role, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.Salary = salary; 
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"The employee's name is {FirstName} {LastName} and the amount of salary is {GetSalary()} dollars.");
        }
    }
}
