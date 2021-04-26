using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class07.ClassLibrary.Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, Role role, double salary, double successSaleRevenue) : base(firstName, lastName, role, salary)
        {
            this.SuccessSaleRevenue = successSaleRevenue;
        }
        public double SuccessSaleRevenue { get; set; }

        public void AddSuccessRevenue(double saleRevenue)
        {
            SuccessSaleRevenue += saleRevenue;
        }

        public override double GetSalary()
        {
            double baseSalary = base.GetSalary();
            double bonus;

            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else 
            {
                bonus = 1500;
            }

            return (baseSalary + bonus);
        }
    }
}
