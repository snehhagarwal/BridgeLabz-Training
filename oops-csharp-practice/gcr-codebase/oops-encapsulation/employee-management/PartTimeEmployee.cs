using System;

public class PartTimeEmployee : Employee, IDepartment
{
    public int HoursWorked{get;set;}

    private string department;

    public override double CalculateSalary()
    {
        return HoursWorked*BaseSalary;
    }

    public void AssignDepart(string dept)
    {
        department=dept;

    }

    public string GetDepart()
    {
        return department;
    }
}