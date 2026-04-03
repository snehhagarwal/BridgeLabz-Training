using System;

public class Clothing : Product
{
    public override double CalculateDiscount()
    {
        return Price*0.20;
    }
}