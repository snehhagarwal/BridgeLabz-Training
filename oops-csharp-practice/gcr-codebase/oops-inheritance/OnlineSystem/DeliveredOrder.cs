using System;

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;
    
    public override string GetStatus()
    {
        return "Order Delivered";
    }
}