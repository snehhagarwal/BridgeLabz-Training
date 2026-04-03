using System;
using System.Collections.Generic;

class ShoppingCart
{
    public static void Main()
    {
        // Product → Price
        Dictionary<string, double> cart = new Dictionary<string, double>();

        // Add items
        cart.Add("Laptop", 75000);
        cart.Add("Mouse", 800);
        cart.Add("Keyboard", 1500);

        // Display cart
        Console.WriteLine("Cart:");
        foreach (KeyValuePair<string, double> item in cart)
            Console.WriteLine(item.Key + " : " + item.Value);

        // Price-wise sorting
        SortedDictionary<double, string> sorted =
            new SortedDictionary<double, string>();

        // Invert for sorting
        foreach (KeyValuePair<string, double> item in cart)
            sorted[item.Value] = item.Key;

        // Display sorted items
        Console.WriteLine("\nSorted by Price:");
        foreach (KeyValuePair<double, string> item in sorted)
            Console.WriteLine(item.Value + " : " + item.Key);
    }
}
