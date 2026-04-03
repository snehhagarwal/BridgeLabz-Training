using System;

public class PriceTable
{
    public int[] Prices;

    public PriceTable(int maxLength)
    {
        Prices=new int[maxLength+1];
    }

    public void SetPrice(int length,int price)
    {
        Prices[length]=price;
    }

    public int GetPrice(int length)
    {
        return Prices[length];
    }
}