// InvoiceItem.cs - Represents a single invoice item
using System;
public class InvoiceItem
{
    public string t; // task name
    public double a; // amount
    public int q;    // quantity

    // Constructor
    public InvoiceItem(string name, double amt, int qty = 1)
    {
        t = name; // set name
        a = amt;  // set amount
        q = qty;  // set quantity
    }

    // Calculate total for this item
    public double GetTot()
    {
        return a * q;
    }

    // Display item details
    public void Show()
    {
        // print details
        if (!string.IsNullOrEmpty(t) && a >= 0 && q > 0)
        {
            Console.WriteLine(t + " x" + q + " " + a.ToString("F2") + "  " + GetTot().ToString("F2"));
        }
        else
        {
            Console.WriteLine("Invalid item details.");
        }
    }
}
