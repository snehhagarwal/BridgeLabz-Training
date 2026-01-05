using System;

public class Customer
{
    // Customer name
    public string Name{get;set;}

    // Constructor
    public Customer(string name)
    {
        Name=name;
    }

    // Display customer name
    public void ShowCustomer()
    {
        Console.WriteLine("Customer: " + Name);
    }
}