using System;

class Menu
{
    private string[] items;
    private bool[] available;
    private double[] prices;

    public Menu(string[] items,double[] prices)
    {
        this.items=items;
        this.prices=prices;
        available=new bool[items.Length];

        for(int i = 0; i < available.Length; i++)
        {
            available[i]=true;
        }
    }

    public void Display()
    {
        for(int i = 0; i < items.Length; i++)
        {
            string status=available[i] ? "Available" : "Not Available";
            Console.WriteLine(i+1 + ". " + items[i] + " - " + prices[i] + " " + status);
        }
    }

    public bool IsAvailable(int idx)
    {
        if(idx<0 || idx >= items.Length)
        {
            return false;
        }
        return available[idx];
    }

    public string GetItemByIndex(int idx)
    {
        if(idx<0 || idx >= items.Length)
        {
            return null;
        }
        return items[idx];
    }

    public double GetPrice(int idx)
    {
        if(idx<0 || idx >= prices.Length)
        {
            return 0;
        }
        return prices[idx];
    }

    public void MarkUnavailable(int idx)
    {
        if(idx>=0 && idx < items.Length)
        {
            available[idx]=false;
        }
    }


}