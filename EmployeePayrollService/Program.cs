using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Payroll Service Using ADO.Net!");

            EmployeeRepo repo = new EmployeeRepo();
            repo.ConnectionString();
            EmployeePayroll employee = new EmployeePayroll();

            employee.id = 01;
            employee.name = "Mayur";
            employee.phone = "9863907678";
            employee.address = "9865 KY Street";
            employee.Department = "Sales";
            employee.Gender = "M";
            employee.basic_pay = 10000.00M;
            employee.deductions = 1500.00;
            employee.taxable_pay = 1500.00;
            employee.tax = 1000.00;
            employee.net_pay = 1400.00;
            employee.Start = Convert.ToDateTime("2020-11-03");
            if (repo.AddEmployee(employee))
                Console.WriteLine("Records added successfully");
            repo.AddEmployee(employee);
        }
    }
}
