using System;

public class VegItem : FoodItem
{
    public override double CalculatePrice()
    {
        return Price*Quantity;
    }
}