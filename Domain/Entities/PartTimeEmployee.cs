using CompanyManagementSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Domain.Entities
{
    public class PartTimeEmployee : Employee, IPayable
    {
        public PartTimeEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }
        public override decimal CalculateBonus()
        {
            return Salary * 0.10m; // Part-time employees get a 10% bonus
        }
        public void ProcessSalary()
        {
            Console.WriteLine($"Processing salary for {Name}. Total amount: {Salary + CalculateBonus():C}");
        }
    }
}
