using System; // Importing System namespace for Console

// Employee class represents a basic employee
// 'class' is internal by default in C#, so it's accessible within the same assembly
class Employee
{
    // 'public' allows these fields to be accessed from other classes and derived classes
    public string Name;
    public int Id;
    public double Salary;

    // 'public' allows this method to be called from outside the class
    // 'virtual' allows derived classes to override this method for specific display behavior
    public virtual void Display()
    {
        // Print employee details
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}