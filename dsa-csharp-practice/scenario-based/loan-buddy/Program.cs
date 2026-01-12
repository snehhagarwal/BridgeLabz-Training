using System;

class Program
{
    static void Main(string[] args)
    {
        // Array used
        Loan[] loans = new Loan[3];

        Applicant applicant = new Applicant("Rahul", 720, 50000, 500000);

        LoanApplication personalApp =
            new LoanApplication("Personal", 36, 12);

        LoanApplication homeApp =
            new LoanApplication("Home", 240, 8);

        LoanApplication autoApp =
            new LoanApplication("Auto", 60, 9);

        loans[0] = new PersonalLoan(applicant, personalApp);
        loans[1] = new HomeLoan(applicant, homeApp);
        loans[2] = new AutoLoan(applicant, autoApp);

        foreach (Loan l in loans)
        {
            bool approved = l.ApproveLoan();
            Console.WriteLine("Approved: " + approved);
            Console.WriteLine("EMI: " + l.CalculateEMI());
        }
    }
}

