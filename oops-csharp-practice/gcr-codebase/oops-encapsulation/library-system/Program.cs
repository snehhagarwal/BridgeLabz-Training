using System;
class Program
{
    static void Main(string[] args)
    {
        Library[] arr=new Library[1];

        Book b=new Book();
        b.ItemId=1;
        b.Title="Java";

        arr[0]=b;

        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].GetDetails();
            Console.WriteLine("Loan Days: " + arr[i].GetDuration());
        } 
    }
}