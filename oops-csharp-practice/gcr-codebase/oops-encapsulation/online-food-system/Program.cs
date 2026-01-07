using System;

class Program
{
    static void Main(string[] args)
    {
        FoodItem[] arr=new FoodItem[1];

        VegItem v=new VegItem();
        v.ItemName="Noodles";
        v.Price=200;
        v.Quantity=2;

        arr[0]=v;

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Total: " + arr[i].CalculatePrice());
        }
    }
}