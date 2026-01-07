using System;

public abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId{get=>productId; set=>productId=value;}
    public string name{get=>name;set=>name=value;}
    public double Price{get=>price;set=>price=value;}

    public abstract double CalculateDiscount();
}