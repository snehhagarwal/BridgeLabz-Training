using System;

public class FullTimeEmployee: Employee, IDepartment
{
    private string department;

    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public void AssignDepart(string department)
    {
        this.department=department;
    }
    public string GetDepart()
    {
        return department;
    }
}