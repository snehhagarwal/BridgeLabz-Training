using System.Collections.Generic;

public class Customer
{
    // Customer name
    public string Name { get; set; }

    // Cart: item → quantity
    public Dictionary<string, int> Cart { get; set; }

    // Constructor
    public Customer(string name)
    {
        Name = name;
        Cart = new Dictionary<string, int>();
    }

    // Add item to cart
    public void AddItem(string item, int qty)
    {
        // Update quantity if exists
        if (Cart.ContainsKey(item))
            Cart[item] += qty;
        else
            Cart[item] = qty;
    }
}
