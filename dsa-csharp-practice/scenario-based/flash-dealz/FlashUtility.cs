using System;
using System.Collections.Concurrent;

class FlashUtility : IFlashDealz
{
    int n=Convert.ToInt32(Console.ReadLine());
    private Product[] products=new Product[n];
    private int count=0;

    public void AddProduct()
    {
        Console.Write("Enter Product name: ");
        string name=Console.ReadLine();

        Console.Write("Enter Discount: ");
        int discount=Convert.ToInt32(Console.ReadLine());

        products[count++]=new Product(name,discount);
        Console.WriteLine("Product added");
    }

    public void SortProducts()
    {
        QuickSort(products,0,count-1);
        Console.WriteLine("Products sorted");
    }

    public void Display()
    {
        if (count == 0)
        {
            Console.WriteLine("No products available");
            return;
        }

        Console.WriteLine("Product List");
        for(int i = 0; i < count; i++)
        {
            products[i].Display();
        }
    }

    private void QuickSort(Product[] arr,int low,int high)
    {
        if (low < high)
        {
            int p=Partition(arr,low,high);
            QuickSort(arr,low,p-1);
            QuickSort(arr,p+1,high);
        }
    }

    private int Partition(Product[] arr,int low,int high)
    {
        int pivot=arr[high].GetDiscount();
        int i=low-1;

        for(int j = low; j < high; j++)
        {
            if (arr[i].GetDiscount() > pivot)
            {
                i++;
                Swap(arr,i,j);
            }
        }

        Swap(arr,i+1,high);
        return i+1;
    }

    private void Swap(Product[] arr,int i,int j)
    {
        Product temp=arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
    }
}