using System;

class Patient
{
    public static string HospitalName="City Hospital"; // static hospital name
    private static int total=0; // static patient count
    public readonly int PatientId; // read-only patient id
    public string Name; // patient name
    public int Age; // patient age
    public string Ailment; // patient ailment

    public Patient(string name,int num,string str)
    {
        this.Name=name; // set name
        this.Age=num; // set age
        this.Ailment=str; // set ailment
        total++; // increment total
        this.PatientId=total; // assign patient id
    }

    public static void GetTotal()
    {
        Console.WriteLine("Total Patients: " + total);
    }

    public void Display()
    {
        if(this is Patient) // type check (redundant)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient: " + PatientId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
        }
        else
        {
            Console.WriteLine("Not a Valid Patient");
        }
    }
}

class HospitalSystem
{
    static void Main(string[] args)
    {
        Patient p1=new Patient("John",20,"Fracture"); // create patient 1
        Patient p2=new Patient("Sam",30,"Flu"); // create patient 2

        p1.Display(); // show patient 1
        p2.Display(); // show patient 2

        Patient.GetTotal(); // show total patients
    }
}