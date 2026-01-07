using System;

class Program
{
    static void Main(string[] args)
    {
        Employee[] arr=new Employee[2];
        FullTimeEmployee f=new FullTimeEmployee();
        f.EmployeeId=101;
        f.Name="Ram";
        f.BaseSalary=50000;
        f.AssignDepart("IT");

        PartTimeEmployee p=new PartTimeEmployee();
        p.EmployeeId=102;
        p.Name="Sita";
        p.BaseSalary=500;
        p.HoursWorked=40;
        p.AssignDepart("HR");

        arr[0]=f;
        arr[1]=p;

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].Display();
        }

    }
}