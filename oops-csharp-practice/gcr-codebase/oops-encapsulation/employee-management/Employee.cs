using System;

public abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public int EmployeeId{get=>employeeId;set=>employeeId=value;}
    public string Name{get=>name;set=>name=value;}
    public double BaseSalary{get=>baseSalary;set=>baseSalary=value;}

    public abstract double CalculateSalary();

    public void Display()
    {
        Console.WriteLine("Id: " + EmployeeId + " Name: " + Name + " Salary: " + CalculateSalary());
    }
}