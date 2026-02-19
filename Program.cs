using CompanyManagementSystem.Application.Services;
using CompanyManagementSystem.Domain.Entities;

class Program
{ 
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Haris", 50000),
            new PartTimeEmployee(2, "Rahim", 20000)
        };
        var payrollService = new PayrollService();
        payrollService.ProcessPayroll(employees);
    }
}