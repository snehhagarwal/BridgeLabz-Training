using System;

class Progam
{
    static void Main(string[] args)
    {
        Patient[] arr=new Patient[1];

        InPatient ip=new InPatient();
        ip.PatientId=101;
        ip.Name="Ram";
        ip.Age=20;
        ip.Days=20;

        arr[0]=ip;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i].GetDetails();    // Display details
            Console.WriteLine("Bill: " + arr[i].CalculateBill());
        }
    }
}