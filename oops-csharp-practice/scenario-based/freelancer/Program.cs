// Program.cs - Main application for Invoice Generator
using System;

class P
{
    static void Main(string[] a)
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine("     FREELANCER INVOICE GENERATOR");
        Console.WriteLine(new string('=', 60));

        InvoiceTester t = new InvoiceTester();

        bool run = true;

        while (run)
        {
            Console.WriteLine("\n=== MAIN MENU ===");
            Console.WriteLine("1. Create New Invoice");
            Console.WriteLine("2. Test Invoice Parser");
            Console.WriteLine("3. Test Edge Cases");
            Console.WriteLine("4. Test Tax Calculations");
            Console.WriteLine("5. Run All Tests");
            Console.WriteLine("6. View Sample Invoices");
            Console.WriteLine("7. Exit");
            Console.Write("\nChoose an option (1-7): ");

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    t.Interactive();
                    break;

                case "2":
                    Console.Clear();
                    t.TestBasic();
                    break;

                case "3":
                    Console.Clear();
                    t.TestEdge();
                    break;

                case "4":
                    Console.Clear();
                    t.TestTax();
                    break;

                case "5":
                    Console.Clear();
                    t.RunAll();
                    break;

                case "6":
                    ShowSample();
                    break;

                case "7":
                    run = false;
                    Console.WriteLine("\nThank you for using Invoice Generator!");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            if (run && ch != "1")
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    // Show sample invoices
    static void ShowSample()
    {
        Console.Clear();
        InvoiceGenerator g = new InvoiceGenerator();

        Console.WriteLine("=== SAMPLE INVOICES ===\n");

        // Sample 1
        Console.WriteLine("Sample 1: Web Development Project");
        Console.WriteLine(new string('-', 50));
        g.GenerateInvoice(
            "Website Design - 15000 INR, Frontend Development - 25000 INR, " +
            "Backend Development - 35000 INR, Testing - 10000 INR",
            "ABC Corporation"
        );

        Console.WriteLine("\n" + new string('=', 60) + "\n");

        // Sample 2
        Console.WriteLine("Sample 2: Graphic Design Project");
        Console.WriteLine(new string('-', 50));
        g.GenerateInvoice(
            "Logo Design - 5000 INR, Business Card - 2000 INR, " +
            "Brochure Design - 8000 INR, Social Media Posts - 4000 INR",
            "XYZ Startup",
            12.5
        );

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
