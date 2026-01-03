using System;

class Order
{
    public int OrderId;
    public string Date;

    public virtual string GetStatus()
    {
        return "Order Placed";
    }
}