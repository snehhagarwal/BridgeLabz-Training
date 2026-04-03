using System;

class ShippedOrder :Order
{
    public string TrackingNumber;
     
    public override string GetStatus()
    {
        return "Order Shipped";
    }
}