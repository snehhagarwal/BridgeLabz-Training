using System;
using System.Collections.Generic;

public class PriceChart
{
    int[] prices;
    
    public PriceChart(int maxLength)
    {
        prices=new int[maxLength+1];
    }

    public void Add(int length,int price)
    {
        if(length>=0 && length < prices.Length)
        {
            prices[length]=price;
        }
    }

    public int Get(int length)
    {
        if(length>=0 && length < prices.Length)
        {
            return prices[length];
        }
        return 0;
    }

    public int[] GetAll()
    {
        return prices;
    }
}