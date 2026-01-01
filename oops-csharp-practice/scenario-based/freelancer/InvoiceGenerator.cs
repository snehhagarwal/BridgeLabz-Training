// InvoiceGenerator.cs - Creates formatted invoices
using System;
public class InvoiceGenerator
{
    private InvoiceParser p; // parser

    // Constructor
    public InvoiceGenerator()
    {
        p = new InvoiceParser(); // create parser
    }

    // Generate invoice from input string
    public void GenerateInvoice(string inp, string client = "", double tax = 18.0)
    {
        Console.Clear();
        Console.WriteLine("=======================================================================");
        Console.WriteLine("                     INVOICE");
        Console.WriteLine("=======================================================================");

        // Invoice number and date
        string invNo = p.GenerateInvoiceNumber();
        Console.WriteLine("Invoice No: " + invNo);
        Console.WriteLine("Date: " + DateTime.Now.ToString("dd-MMM-yyyy"));
        Console.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));

        if (!string.IsNullOrEmpty(client))
        {
            Console.WriteLine("Client: " + client);
        }

        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("Description                     Qty    Rate       Amount");
        Console.WriteLine("-----------------------------------------------------------------------");

        // Parse and display items
        string[] arr = p.ParseInvoice(inp);
        InvoiceItem[] items = new InvoiceItem[arr.Length];

        double sub = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            string t = p.ExtractTaskName(arr[i]);
            double amt = p.ExtractAmount(arr[i]);

            items[i] = new InvoiceItem(t, amt);
            items[i].DisplayItem();

            sub += amt;
        }

        Console.WriteLine("-----------------------------------------------------------------------");

        // Show calculations
        Console.WriteLine("Subtotal:".PadRight(40) + p.FormatCurrency(sub).PadLeft(25));
        double tx = p.CalculateTax(sub, tax);
        Console.WriteLine(("Tax (" + tax + "%):").PadRight(40) + p.FormatCurrency(tx).PadLeft(25));
        double tot = p.CalculateFinalTotal(sub, tax);
        Console.WriteLine("Total Amount:".PadRight(40) + p.FormatCurrency(tot).PadLeft(25));

        Console.WriteLine("=======================================================================");
        Console.WriteLine("Thank you for your business!");
        Console.WriteLine("=======================================================================");
    }

    // Generate detailed breakdown
    public void GenerateDetailedReport(string inp)
    {
        Console.WriteLine("\n=== INVOICE DETAILED BREAKDOWN ===\n");

        string[] arr = p.ParseInvoice(inp);

        if (arr.Length == 0)
        {
            Console.WriteLine("No tasks found in the invoice.");
            return;
        }

        Console.WriteLine("Task List:");
        Console.WriteLine("----------------------------------------");

        for (int i = 0; i < arr.Length; i++)
        {
            string t = p.ExtractTaskName(arr[i]);
            double amt = p.ExtractAmount(arr[i]);

            Console.WriteLine((i + 1).ToString() + ". " + t + ": " + p.FormatCurrency(amt));
        }

        Console.WriteLine("----------------------------------------");

        double tot = p.GetTotalAmount(arr);
        Console.WriteLine("Total: " + p.FormatCurrency(tot));

        // Tax calculations
        Console.WriteLine("\nTax Calculations:");
        Console.WriteLine("----------------------------------------");

        double[] rates = { 5.0, 12.0, 18.0, 28.0 };

        for (int i = 0; i < rates.Length; i++)
        {
            double tx = p.CalculateTax(tot, rates[i]);
            double totWithTax = tot + tx;

            Console.WriteLine(rates[i] + "% Tax: " + p.FormatCurrency(tx));
            Console.WriteLine("Total with " + rates[i] + "% Tax: " + p.FormatCurrency(totWithTax));
            Console.WriteLine();
        }
    }

    // Save invoice to text file
    public void SaveInvoiceToFile(
        string inp,
        string client = "",
        string fname = "invoice.txt"
    )
    {
        string[] arr = p.ParseInvoice(inp);
        double sub = p.GetTotalAmount(arr);
        double tx = p.CalculateTax(sub);
        double tot = p.CalculateFinalTotal(sub);

        string content = "INVOICE\n";
        content += "==================================================\n";
        content += "Invoice No: " + p.GenerateInvoiceNumber() + "\n";
        content += "Date: " + DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") + "\n";

        if (!string.IsNullOrEmpty(client))
        {
            content += "Client: " + client + "\n";
        }

        content += "--------------------------------------------------\n";
        content += "Tasks:\n";

        for (int i = 0; i < arr.Length; i++)
        {
            string t = p.ExtractTaskName(arr[i]);
            double amt = p.ExtractAmount(arr[i]);
            content += "  " + (i + 1) + ". " + t + ": " + p.FormatCurrency(amt) + "\n";
        }

        content += "--------------------------------------------------\n";
        content += "Subtotal: " + p.FormatCurrency(sub) + "\n";
        content += "Tax (18%): " + p.FormatCurrency(tx) + "\n";
        content += "Total: " + p.FormatCurrency(tot) + "\n";
        content += "==================================================\n";
        content += "Thank you for your business!\n";

        // Save to file using if-else for error handling
        if (!string.IsNullOrEmpty(fname))
        {
            System.IO.File.WriteAllText(fname, content); // write to file
            Console.WriteLine("Invoice saved to " + fname);
        }
        else
        {
            Console.WriteLine("Error saving invoice to file.");
        }
    }
}
