using CompanyManagementSystem.Domain.Entities;
using CompanyManagementSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Application.Services
{
    public class PayrollService
    {
        public void ProcessPayroll(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee is IPayable payable)
                {
                    payable.ProcessSalary();
                }

                Console.WriteLine($"Bonus: {employee.CalculateBonus()}");
                Console.WriteLine("----------------------------");

            }
        }
    }
}
