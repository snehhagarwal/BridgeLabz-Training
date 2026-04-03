using System;

class Bank
{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    //default constructor
    public Bank(){}

    //parameterized constructor
    public Bank(int acc,string holder,double balance)
    {
        accountNumber=acc;
        accountHolder=holder;
        this.balance=balance;
    }

    //setter to set balance
    public void SetBalance(double amnt)
    {
        balance=amnt;
    }
    
    //getter to get balance
    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : Bank
{
    //parameterized constructor
    public SavingsAccount(int acc,string holder,double balance)
    {
        accountNumber=acc;
        accountHolder=holder;
        SetBalance(balance);
    }

    //o display the details
    public void Display()
    {
        Console.WriteLine("Account Deatils");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + GetBalance());
    }
}

class BankAccount
{
    static void Main(string[] args)
    {
        Console.Write("Enter Account Number: ");
        int acc=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        string holder=Console.ReadLine();

        Console.Write("Enter balance: ");
        double balance=Convert.ToDouble(Console.ReadLine());

        SavingsAccount sa=new SavingsAccount(acc,holder,balance);
        sa.Display();
    }
}