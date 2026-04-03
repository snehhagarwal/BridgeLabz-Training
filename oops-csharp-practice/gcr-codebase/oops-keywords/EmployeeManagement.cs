using System;

class Employee
{
    public static string CompanyName="Octro"; // static company name
    private static int total=0; // static employee count

    public readonly int Id; // read-only id
    public string Name; // employee name
    public string Designation; // employee designation

    public Employee(string name,int id,string designation)
    {
        this.Name=name; // set name
        this.Id=id; // set id
        this.Designation=designation; // set designation
        total++; // increment count
    }

    public static void DisplayEmployee()
    {
        Console.WriteLine("Total Employee: " + total);
    }

    public void DisplayDetails()
    {
        if(this is Employee) // type check (redundant)
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Designation: " + Designation);
        }
        else
        {
            Console.WriteLine("Not a valid Employee");
        }
    }
}

class EmployeeManagement
{
    static void Main(string[] args)
    {
        Employee e1=new Employee("John",1,"Developer"); // create employee 1
        Employee e2=new Employee("Olly",2,"Manager"); // create employee 2

        e1.DisplayDetails(); // show employee 1
        e2.DisplayDetails(); // show employee 2

        Employee.DisplayEmployee(); // show total employees
    }
}