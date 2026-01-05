using System;

public class OutPatient : Patient,IPayable
{
    // Consultation fee
     public double Fee
     {
         get;
         set;
     }
    // Constructor
     public OutPatient(int id,string name,int age,double fee)
     {
        PatientId=id;
        Name-name;
        Age=age;
        Fee=fee;
     }

    // Returns bill amount
     public double CalculateBill()
     {
         return Fee;
     }
     
    // Displays outpatient details
     public override void Display()
     {
        Console.WriteLine("OutPatient Details");
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Consultation Fee: " + CalculateBill());
     }
}
         
