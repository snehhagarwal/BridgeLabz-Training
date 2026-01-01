// InvoiceTester.cs - Tests invoice parsing and generation
using System;
public class InvoiceTester
{
    private InvoiceParser p; // parser
    private InvoiceGenerator g; // generator

    // Constructor
    public InvoiceTester()
    {
        p = new InvoiceParser(); // create parser
        g = new InvoiceGenerator(); // create generator
    }

    // Test basic parsing
    public void TestBasic()
    {
        Console.WriteLine("=== TEST BASIC PARSING ===\n");

        string s1 = "Logo Design - 3000 INR, Web Page - 4500 INR";
        string s2 = "Consultation - 1500, Development - 8000, Testing - 2000";
        string s3 = "Single Task - 5000";
        string s4 = "";
        string s5 = "Design-$300, Coding-4000 INR, Testing - 2500 Rupees";

        string[][] tc =
        {
            new string[] { s1, "Standard format" },
            new string[] { s2, "Without currency" },
            new string[] { s3, "Single task" },
            new string[] { s4, "Empty input" },
            new string[] { s5, "Mixed currencies" },
        };

        for (int i = 0; i < tc.Length; i++)
        {
            Console.WriteLine("Test " + (i + 1) + ": " + tc[i][1]);
            Console.WriteLine("Input: \"" + tc[i][0] + "\"");

            string[] tasks = p.ParseInvoice(tc[i][0]);
            Console.WriteLine("Parsed " + tasks.Length + " tasks:");

            for (int j = 0; j < tasks.Length; j++)
            {
                string t = p.ExtractTaskName(tasks[j]);
                double a = p.ExtractAmount(tasks[j]);
                Console.WriteLine("  Task " + (j + 1) + ": " + t + " = " + p.FormatCurrency(a));
            }

            double tot = p.GetTotalAmount(tasks);
            Console.WriteLine("Total: " + p.FormatCurrency(tot) + "\n");
        }
    }

    // Test edge cases
    public void TestEdge()
    {
        Console.WriteLine("=== TEST EDGE CASES ===\n");

        string[] ec =
        {
            "Logo Design - 3000 INR, Web Page - 4500 INR, SEO - 2000",
            "Only Task Name",
            "-5000",
            "Task1 - ABC, Task2 - XYZ",
            "Task - 1000.50, Task2 - 2000.75",
            "Task - ₹2500, Task2 - $100, Task3 - 3000 INR",
        };

        for (int i = 0; i < ec.Length; i++)
        {
            Console.WriteLine("Edge " + (i + 1) + ":");
            Console.WriteLine("Input: \"" + ec[i] + "\"");

            string[] tasks = p.ParseInvoice(ec[i]);
            double tot = p.GetTotalAmount(tasks);

            Console.WriteLine("Parsed " + tasks.Length + " tasks, Total: " + p.FormatCurrency(tot));

            for (int j = 0; j < tasks.Length; j++)
            {
                string t = p.ExtractTaskName(tasks[j]);
                double a = p.ExtractAmount(tasks[j]);
                Console.WriteLine("  " + t + ": " + p.FormatCurrency(a));
            }
            Console.WriteLine();
        }
    }

    // Test tax calculations
    public void TestTax()
    {
        Console.WriteLine("=== TEST TAX CALCULATIONS ===\n");

        string s = "Design - 5000, Development - 10000, Testing - 3000";
        string[] tasks = p.ParseInvoice(s);
        double sub = p.GetTotalAmount(tasks);

        Console.WriteLine("Subtotal: " + p.FormatCurrency(sub) + "\n");

        double[] rates = { 0, 5, 12.5, 18, 28 };

        for (int i = 0; i < rates.Length; i++)
        {
            double tx = p.CalculateTax(sub, rates[i]);
            double tot = p.CalculateFinalTotal(sub, rates[i]);

            Console.WriteLine("Tax Rate: " + rates[i] + "%");
            Console.WriteLine("Tax Amount: " + p.FormatCurrency(tx));
            Console.WriteLine("Total with Tax: " + p.FormatCurrency(tot) + "\n");
        }
    }

    // Run all tests
    public void RunAll()
    {
        TestBasic();
        TestEdge();
        TestTax();
    }

    // Interactive invoice creation
    public void Interactive()
    {
        Console.WriteLine("=== INTERACTIVE INVOICE CREATION ===\n");

        Console.WriteLine("Enter tasks: 'Task Name - Amount, Task Name - Amount, ...'");
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Development - 8000 INR");
        Console.WriteLine("\nEnter your invoice items:");

        string inp = Console.ReadLine();

        if (string.IsNullOrEmpty(inp))
        {
            Console.WriteLine("No input provided!");
            return;
        }

        Console.Write("\nEnter client name (optional): ");
        string c = Console.ReadLine();

        Console.Write("Enter tax rate (default 18%): ");
        string t = Console.ReadLine();

        double tx = 18.0;
        if (!string.IsNullOrEmpty(t) && double.TryParse(t, out double r))
        {
            tx = r;
        }

        Console.WriteLine("\n============================================================");
        Console.WriteLine("Generating Invoice...");
        Console.WriteLine("============================================================\n");

        // Generate invoice
        g.GenerateInvoice(inp, c, tx);

        // Ask for detailed report
        Console.Write("\nShow detailed breakdown? (Y/N): ");
        string show = Console.ReadLine().ToUpper();

        if (show == "Y" || show == "YES")
        {
            g.GenerateDetailedReport(inp);
        }

        // Ask to save to file
        Console.Write("\nSave invoice to file? (Y/N): ");
        string save = Console.ReadLine().ToUpper();

        if (save == "Y" || save == "YES")
        {
            Console.Write("Enter filename (default: invoice.txt): ");
            string f = Console.ReadLine();

            if (string.IsNullOrEmpty(f))
            {
                f = "invoice.txt";
            }

            g.SaveInvoiceToFile(inp, c, f);
        }
    }
}
