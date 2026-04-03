using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        // Employee array
        private Employee[] employees;

        const int full_time = 1;
        const int part_time = 2;
        const int wage_per_hour = 20;
        const int full_day_hour = 8;
        const int part_time_hour = 4;
        const int total_working_days = 20;
        const int max_working_hours = 100;

        // Random attendance
        Random attendanceStatus = new Random();

        // UC0: Add employee details
        public Employee[] AddEmployee()
        {
            Console.Write("Enter number of employees: ");
            int count = Convert.ToInt32(Console.ReadLine());

            employees = new Employee[count];

            int i = 0;
            for (; i < count; i++)
            {
                employees[i] = new Employee();

                Console.Write("Enter Employee ID: ");
                employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                employees[i].EmployeeName = Console.ReadLine();
            }
            return employees;
        }

        // UC2 & UC3: Calculate daily wage including full-time and part-time
        public void CalculateDailyWage(Employee employee)
        {
            //UC1:- Attendance functionality
            // Random value: 0-Absent, 1-FullTime, 2-PartTime
            int empCheck = attendanceStatus.Next(0, 3);
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
                    Console.WriteLine("Employee is absent");
                    break;
            }

            employee.EmployeeSalary = empHours * wage_per_hour;
            Console.WriteLine(employee);
        }

        //UC5:- Monthly Wage functionality
        public void CalculateMonthlyWage(Employee employee)
        {
            int totalWage = 0;
            int day = 1;

            for (; day <= total_working_days; day++)
            {
                int empCheck = attendanceStatus.Next(0, 3);
                int empHours = 0;

                //UC4:- Switch case functionality
                switch (empCheck)
                {
                    case full_time:
                        empHours = full_day_hour;
                        break;

                    case part_time:
                        empHours = part_time_hour; // UC3: Part-Time Wage
                        break;
                }

                totalWage += empHours * wage_per_hour;
            }

            employee.EmployeeSalary = totalWage;
            Console.WriteLine(employee);
        }

        //UC6:- Wages Till Condition Functionality
        public void CalculateWageTillCondition(Employee employee)
        {
            int totalHours = 0;
            int totalDays = 0;

            while (totalHours < max_working_hours && totalDays < total_working_days)
            {
                totalDays++;
                int empCheck = attendanceStatus.Next(0, 3);
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
                }

                totalHours += empHours;
            }

            employee.EmployeeSalary = totalHours * wage_per_hour;

            Console.WriteLine("Total Number of Days: " + totalDays);
            Console.WriteLine("Total Number of Hours: " + totalHours);
            Console.WriteLine(employee);
        }
    }
}
