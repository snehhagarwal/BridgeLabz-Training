using System;

public class ClothingCategory : ProductCategory{
    public string Size { get; set; }

    public ClothingCategory(string size)
        : base("Clothing")
    {
        Size = size;
    }

    public override void DisplayCategory()
    {
        Console.WriteLine($"Category: Clothing | Size: {Size}");
    }
}
