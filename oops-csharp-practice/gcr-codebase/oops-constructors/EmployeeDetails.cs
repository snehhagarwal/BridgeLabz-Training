using System;
using System.Data;

class Employee
{
    public int employeeId; //public variable 
    protected string department; //protected variable
    private double salary;  //private variable

    //default constructor
    public Employee(){}

    //parameterized constructor
    public Employee(int id,string dept,double salary)
    {
        employeeId=id;
        department=dept;
        this.salary=salary;
    }

    //set salary
    public void SetSalary(double salary)
    {
        this.salary=salary;
    }

    //get salary
    public double GetSalary()
    {
        return salary;
    }
}

class Manager : Employee
{
    //parameterized constructor
    public Manager(int id,string dept,double salary)
    {
        employeeId=id;
        department=dept;
        SetSalary(salary);
    }

    //details display
    public void Display()
    {
        Console.WriteLine("Manager Details");
        Console.WriteLine("Employee Id: " + employeeId);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + GetSalary());
    }
}

class EmployeeDetails
{
    static void Main(string[] args)
    {
        //taking input from users
        Console.Write("Enter Employee Id: ");
        int id=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Department: ");
        string dept=Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary=Convert.ToDouble(Console.ReadLine());

        //creating object 
        Manager m=new Manager(id,dept,salary);
        m.Display(); //show output
    }
}