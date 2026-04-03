using System;

class Program
{
    static void Main(string[] args)
    {
        Patient[] arr = new Patient[50]; // store patients
        int cnt = 0;                     // patient count
        int choice = 0;                  // menu choice

        do
        {
            Console.WriteLine("Hospital Management System");
            Console.WriteLine("1. Add In Patient");
            Console.WriteLine("2. Add Out Patient");
            Console.WriteLine("3. Display All Patients");
            Console.WriteLine("4. Generate Bills");
            Console.WriteLine("5. Exit");

            choice = Convert.ToInt32(Console.ReadLine()); // read choice

            switch (choice)
            {
                case 1:
                    Console.Write("Enter ID: ");
                    int inId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string inName = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int inAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Days Admitted: ");
                    int days = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Daily Charge: ");
                    double charge = Convert.ToDouble(Console.ReadLine());

                    arr[cnt] = new InPatient(inId, inName, inAge, days, charge); // add inpatient
                    cnt++;

                    Console.WriteLine("In Patient Added Successfully!");
                    break;

                case 2:
                    Console.Write("Enter ID: ");
                    int outId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string outName = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int outAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Consultation Fee: ");
                    double fee = Convert.ToDouble(Console.ReadLine());

                    arr[cnt] = new OutPatient(outId, outName, outAge, fee); // add outpatient
                    cnt++;

                    Console.WriteLine("Out Patient Added Successfully!");
                    break;

                case 3:
                    Console.WriteLine("Patient Records");
                    for (int i = 0; i < cnt; i++)
                    {
                        arr[i].Display(); // show details
                    }
                    break;

                case 4:
                    Console.WriteLine("Bills");
                    for (int i = 0; i < cnt; i++)
                    {
                        IPayable pay = arr[i] as IPayable; // type casting
                        if (pay != null)
                        {
                            Bill.Generate(pay); // generate bill
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting the program");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 5);
    }
}
