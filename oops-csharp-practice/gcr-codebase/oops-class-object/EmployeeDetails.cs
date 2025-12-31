using System;

class Employee
{
     //global variables 
    public string name;
    public int id;
    public double salary;

    public void Display()
    {
        Console.WriteLine("\nEmployee Details are: ");
        Console.WriteLine("Namw: " +name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
    
}
class EmployeeDetails
{
   static void Main(string[] args)
    {
        //object creation
        Employee emp=new Employee();

        //take input from the user
        Console.WriteLine("Enter the Employee details: ");

        Console.Write("Enter Employee Name: ");
        emp.name=Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        emp.id=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Salary: ");
        emp.salary=Convert.ToDouble(Console.ReadLine());

        //function call within another class
        emp.Display();
    }
    
}