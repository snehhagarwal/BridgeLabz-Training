using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount[] arr=new BankAccount[];

        SavingsAccount s=new SavingsAccount();
        s.AccountNumber=101;
        s.HolderName="Ram";
        s.Balance=50000;

        arr[0]=s;

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Interest: " + arr[i].CalculateInterest());
        }
    }
}