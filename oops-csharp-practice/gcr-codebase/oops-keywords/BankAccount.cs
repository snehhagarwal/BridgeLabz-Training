using System;

// Bank class definition
class Bank
{
    public static string BankName="SBI Bank";// static bank name
    private static int totalAccount=0;// static account counter

    public readonly int AccountNumber; // read-only account number
    public string AccountHolder; // account holder name
    public double Balance; // account balance

    // Constructor
    public Bank(string name,int num,double balance)
    {
        this.AccountHolder=name;  // set name
        this.AccountNumber=num;   // set account number
        this.Balance=balance;     // set balance
        totalAccount++;           // increment total accounts
    }

    // Show total accounts
    public static void GetTotal()
    {
        Console.WriteLine("Total Account: " + totalAccount);
    }

    // Display account info
    public void Display()
    {
        if(this is BankAccount)   // check type (redundant)
        {
            Console.WriteLine("Bank: " + BankName);
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Not a valid BankAccount object");
        }
    }
}

// Main class
class BanKAccount
{
    public static void Main(string[] args)
    {
        Bank b1=new Bank("John",101,6000);   // create account 1
        Bank b2=new Bank("Bob",102,10000);   // create account 2

        b1.Display();   // show account 1
        b2.Display();   // show account 2

        Bank.GetTotal();  // show total accounts
    }
}