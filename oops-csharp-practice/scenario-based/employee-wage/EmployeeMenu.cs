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

            // Menu options for different UCs
            Console.WriteLine("1. Calculate Daily Wage");
            Console.WriteLine("2. Calculate Monthly Wage");
            Console.WriteLine("3. Calculate Wage till Condition");
            Console.WriteLine("Enter Choice: ");

            int choice=Convert.ToInt32(Console.ReadLine());

            // UC4: Using switch case to execute logic
            switch (choice)
            {
                case 1:
                    // UC1, UC2, UC3: Present/Absent, Daily wage, Part-time wage functionality calculation
                    employeeUtility.CalculateDailyWage();
                    break;
                case 2:
                    // UC5: Monthly Wage Functionality calculation
                    employeeUtility.CalculateMonthlyWage();
                    break;
                case 3:
                    // UC6: Wages till condition functionality calculation
                    employeeUtility.CalculateWageTillCondition();
                    break;
                default:
                    //handles invalid choices 
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
