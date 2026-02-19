using CompanyManagementSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Domain.Entities
{
    public class FullTimeEmployee : Employee, IPayable
    { 
        public FullTimeEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }
        public override decimal CalculateBonus()
        {
            return Salary * 0.20m; // Full-time employees get a 20% bonus
        }
        public void ProcessSalary()
        {
            Console.WriteLine($"Processing salary for {Name}. Total amount: {Salary + CalculateBonus():C}");
        }

    }
}
