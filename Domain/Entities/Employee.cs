using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Domain.Entities
{
    public abstract class Employee
    {
        private decimal _salary;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { 
         get => _salary;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                _salary = value;
            }
        }
        protected Employee(int id, string name, decimal salary) {
            Id = id;
            Name = String.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Name cannot be null or empty.") : name;
            Salary = salary;
        }
        public abstract decimal CalculateBonus();
    }
}
