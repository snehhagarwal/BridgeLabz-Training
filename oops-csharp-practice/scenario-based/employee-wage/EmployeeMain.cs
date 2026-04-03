using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{
    internal class EmployeeMain
    {
        public static void Main(string[] args)
        {
            // UC0: Display welcome message
            Console.WriteLine("Welcome to Employee Wage Program");

            // Creating EmployeeMenu object
            EmployeeMenu employeeMenu = new EmployeeMenu();

            // Calling menu to execute UC1–UC6 operations
            employeeMenu.EmployeeMenuChoices();
        }
    }
}
