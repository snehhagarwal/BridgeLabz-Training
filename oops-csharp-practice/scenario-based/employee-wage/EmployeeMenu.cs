using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{
    sealed class EmployeeMenu
    {
        //taking user input
        int choice;
        private IEmployee employeeUtility;

        public void EmployeeMenuChoices()
        {
            employeeUtility = new EmployeeUtilityImpl();

            Employee[] employees = employeeUtility.AddEmployee();

            // Menu options for different UCs
            Console.WriteLine("1. Calculate Daily Wage");
            Console.WriteLine("2. Calculate Monthly Wage");
            Console.WriteLine("3. Calculate Wage till Condition");
            Console.WriteLine("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            for (; i < employees.Length; i++)
            {
                // UC4: Using switch case to execute logic
                switch (choice)
                {
                    case 1:
                        // UC1, UC2, UC3: Present/Absent, Daily wage, Part-time wage functionality calculation
                        employeeUtility.CalculateDailyWage(employees[i]);
                        break;

                    case 2:
                        // UC5: Monthly Wage Functionality calculation
                        employeeUtility.CalculateMonthlyWage(employees[i]);
                        break;

                    case 3:
                        // UC6: Wages till condition functionality calculation
                        employeeUtility.CalculateWageTillCondition(employees[i]);
                        break;

                    default:
                        //handles invalid choices
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
