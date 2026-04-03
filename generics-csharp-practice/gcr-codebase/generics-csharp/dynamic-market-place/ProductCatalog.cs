using System;
using System.Collections.Generic;

public class ProductCatalog<TProduct>{
    private List<TProduct> products = new List<TProduct>();

    public void AddProduct(TProduct product){
        products.Add(product);
    }

    public void RemoveProduct(TProduct product){
        products.Remove(product);
    }

    public void DisplayCatalog(){
        foreach (var product in products){
            dynamic p = product; // For generic display flexibility
            p.Display();
            Console.WriteLine("----------------------");
        }
    }

    public List<TProduct> GetAllProducts(){
        return products;
    }
}
