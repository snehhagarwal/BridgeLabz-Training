using System;

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount sa = new SavingsAccount();
        sa.AccountNumber = 101;
        sa.Balance = 5000;
        sa.rate = 4.5;
        sa.Display();

        Console.WriteLine();

        CheckingAccount ca = new CheckingAccount();
        ca.AccountNumber = 102;
        ca.Balance = 3000;
        ca.Withdraw = 1000;
        ca.Display();

        Console.WriteLine();

        FixedDepositAccount fd = new FixedDepositAccount();
        fd.AccountNumber = 103;
        fd.Balance = 20000;
        fd.Tenure = 3;
        fd.Display();
    }
}