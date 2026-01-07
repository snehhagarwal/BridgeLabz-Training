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
        private int empId;

        // Stores employee name
        private string empName;

        // Stores employee salary
        private double dailyWage;

        //setting values using getters and setters 
        public int EmployeeId { get=>empId; set => empId = value; }

        public string EmployeeName { get=>empName; set => empName = value; }

        public double DailyWage { get => dailyWage; set => dailyWage = value; }


        // Returns employee details as string
        public override string ToString()
        {
            return "Employee ID: " + EmployeeId + ", Employee Name: " + EmployeeName + ", Employee Salary: " + DailyWage;
        }
    }
}
