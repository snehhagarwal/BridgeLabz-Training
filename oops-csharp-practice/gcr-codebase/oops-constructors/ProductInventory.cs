using System;

class Product
{
    public string ProductName;
    public double Price;
    //class variable
    public static int TotalProducts=0;

   //count the number of total products
    public Product()
    {
        TotalProducts++;
    }

    //display product details
    public void DisplayProduct()
    {
        Console.WriteLine(ProductName + " " + Price);
    }

    //display total amount of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products are: " + TotalProducts);
    } 
}

class ProductInventory
{
    static void Main(string[] args)
    {
        //object creation 
        Product p1=new Product();
        Product p2=new Product();

        //displaying number of products
        Product.DisplayTotalProducts();
    }
}