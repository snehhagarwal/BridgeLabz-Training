using System;

public class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return Price*0.10;
    }

    public double CalculateTax()
    {
        return Price*0.18;
    }

    public string GetTax()
    {
        return "18% GST";
    }
}