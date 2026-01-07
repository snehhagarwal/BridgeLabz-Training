using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] arr=new Product[2];

        Electronics e=new Electronics();
        e.Price=2000;

        Clothing c=new Clothing();
        c.Price=1000;

        arr[0]=e;
        arr[1]=c;

        for(int i = 0; i < arr.Length; i++)
        {
            Product p=arr[i];

            double tax=p is ITaxable t ? t.CalculateTax() : 0;
            double finalPrice=p.Price + tax - p.CalculateDiscount();

            Console.WriteLine(finalPrice);
        }
    }
}