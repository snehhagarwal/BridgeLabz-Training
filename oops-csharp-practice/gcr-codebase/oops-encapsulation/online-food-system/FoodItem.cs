using System;

public abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName{get=>itemName;set=>itemName=value;}
    public double Price{get=>price;set=>price=value;}
    public int Quantity{get=>quantity;set=>quantity=value;}

    public abstract double CalculatePrice();
}