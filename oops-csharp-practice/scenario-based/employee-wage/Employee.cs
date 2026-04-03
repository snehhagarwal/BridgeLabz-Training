using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{
    internal class Employee
    {
        // Stores employee ID
        public int EmployeeId { get; set; }

        // Stores employee name
        public string EmployeeName { get; set; }

        // Stores employee salary
        public double EmployeeSalary { get; set; }

        // Returns employee details as string
        public override string ToString()
        {
            return "Employee ID: " + EmployeeId +
                   ", Employee Name: " + EmployeeName +
                   ", Employee Salary: " + EmployeeSalary;
        }
    }
}
