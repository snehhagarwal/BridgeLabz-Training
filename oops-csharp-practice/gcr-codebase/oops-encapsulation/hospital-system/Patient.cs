using System;

class Patient
{
    private int patientId;
    private int age;
    private string name;

    public int PatientId{get=>patientId;set=>patientId=value;}
    public int Age{get=>age;set=>age=value;}
    public string Name{get=>name;set=>name=value;}

    public abstract double CalculateBill();

    public void DisplayDetails()
    {
        Console.WriteLine(PatientId + " " + Name);
    }
}