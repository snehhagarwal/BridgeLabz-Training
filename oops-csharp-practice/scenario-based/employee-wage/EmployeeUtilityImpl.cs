using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{

    internal class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;

        const int full_time = 1;
        const int part_time = 2;
        const int wage_per_hour = 20;
        const int full_day_hour = 8;
        const int part_time_hour = 4;

        Random ran=new Random();

        // UC2 & UC3: Calculate daily wage including full-time and part-time
        public void CalculateDailyWage()
        {
            //UC1:- Attendance functionality
            // Random value: 0-Absent, 1-FullTime, 2-PartTime
            int empCheck =ran.Next(0,3);
            int empHours = 0;

            switch (empCheck)
            {
                case full_time:
                    empHours = full_day_hour;
                    Console.WriteLine("Full Time Employee");
                    break;
                case part_time:
                    empHours = part_time_hour;  // UC3: Part-Time Wage
                    Console.WriteLine("Part Time Employee");
                    break;
                default:
                    empHours = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            int dailyWage = empHours * wage_per_hour;
            Console.WriteLine("Daily Wage: " + dailyWage);
        }

        //UC5:- Monthly Wage funcctionality
        public void CalculateMonthlyWage()
        {
            int totalWage = 0;

            for(int i = 1; i <= 20; i++)
            {
                int empCheck=ran.Next(0,3);
                int empHours = 0;

                //UC4:- Switch case functionality
                switch (empCheck) 
                { 
                    case 1: 
                        empHours = full_day_hour;
                        break;
                    case 2:
                        empHours = part_time_hour; // UC3: Part-Time Wage
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalWage += empHours*wage_per_hour;
            }
            Console.WriteLine("Monthly Wage: " + totalWage);
        }

        //UC6:- Wages Till Condition Functionality
        public void CalculateWageTillCondition()
        {
            int totalHours = 0;
            int totalDays = 0;
            int totalWage = 0;

            while (totalHours < 100 && totalDays < 20)
            {
                totalDays++;
                int empCheck = ran.Next(0, 3);
                int empHours = 0;

                //UC4:- switch case functionality
                switch (empCheck)
                {
                    case full_time:
                        empHours = full_day_hour;
                        break;
                    case part_time:
                        empHours = part_time_hour;
                        break;
                    default:
                        empHours = 0;
                        break;
                }

                totalHours += empHours;
                totalWage += empHours * wage_per_hour;
            }

            Console.WriteLine("Total Number of Days: " + totalDays);
            Console.WriteLine("Total Number of Hours: " + totalHours);
            Console.WriteLine("Total wage for employee: " + totalWage);
        }

        public Employee AddEmployee()
        {
            employee = new Employee();
            return employee;
        }

    }
}
