using System;

public class InPatient : Patient, IPayable
{ 
    // Number of days admitted
    public int DayAdmit
    {
        get;
        set;
    }
    // Daily hospital charge
    public double DailyCharge
    {
        get;
        set;
    }
    
    // Constructor to initialize values
    public InPatient(int id,string name,int age,int days,double charge)
    {
        PatientId=id;
        Name=name;
        Age=age;
        DayAdmit=days;
        DailyCharge=charge;
    }

    // Calculates total bill
    public double CalculateBil()
    {
        return DayAdmit*DailyCharge;
    }
    
    // Displays inpatient details
    public override void Display()
    {
        Console.WriteLine("In-Patient Details");
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Days Admitted: " + DayAdmit);
        Console.WriteLine("Total Bill: " + CalculateBill());
    }
}
    
    
