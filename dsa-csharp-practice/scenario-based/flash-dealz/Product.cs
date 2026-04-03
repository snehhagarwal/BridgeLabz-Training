// Represents product entity
class Product
{
    private string name;   // product name
    private int discount;  // discount value

    public Product(string name,int discount)
    {
        this.name=name;
        this.discount=discount;
    }

    // returns discount
    public int GetDiscount()
    {
        return discount;
    }

    //prints product details
    public void Display()
    {
        Console.WriteLine(name + " - " + discount + " % OFF");
    }
}