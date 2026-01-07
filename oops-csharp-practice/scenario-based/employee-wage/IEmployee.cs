using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employee_wage
{
    internal interface IEmployee
    {
        //UC2 :- Daily wage functionality
        void CalculateDailyWage();   
        //UC5:- Monthly Wage functionality
        void CalculateMonthlyWage();
        //UC6:- Wage Till Condition functionality
        void CalculateWageTillCondition();
        Employee AddEmployee();
    }
}
