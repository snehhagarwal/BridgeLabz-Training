class Product
{
    private string name;
    private int discount;

    public Product(string name,int discount)
    {
        this.name=name;
        this.discount=discount;
    }

    public int GetDiscount()
    {
        return discount;
    }

    public void Display()
    {
        Console.WriteLine(name + " - " + discount + " % OFF");
    }
}