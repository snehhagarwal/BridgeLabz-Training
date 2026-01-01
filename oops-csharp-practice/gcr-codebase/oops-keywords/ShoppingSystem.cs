using System;

class Product
{
    public static double Discount=10; // 10% given
    private static int productCount=0; // product counter

    public readonly int ProductId; // read-only product id
    public string ProductName; // product name
    public double Price; // product price
    public int Quantity; // product quantity

    public Product(string name,double price,int quantity)
    {
        this.ProductName=name; // set name
        this.Price=price; // set price
        this.Quantity=quantity; // set quantity
        productCount++; // increment count
        this.ProductId=productCount; // assign id
    }

    public static void DiscountUpdate(double val)
    {
        Discount=val; // update discount
        Console.WriteLine("Discount updated to " + Discount + "%");
    }

    public void Display()
    {
        if(this is Product) // type check (redundant)
        {
            Console.WriteLine("Product Id: " + ProductId);
            Console.WriteLine("Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount);
        }
        else
        {
            Console.WriteLine("Not a valid Product");
        }
    }
}
class ShoppingSystem
{
    static void Main(string[] args)
    {
        Product p1=new Product("Mobile",30000,1); // create product 1
        Product p2=new Product("Laptop",60000,2); // create product 2

        p1.Display(); // show product 1
        p2.Display(); // show product 2

        Product.DiscountUpdate(20); // update discount
        p1.Display(); // show product 1
        p2.Display(); // show product 2
    }
}