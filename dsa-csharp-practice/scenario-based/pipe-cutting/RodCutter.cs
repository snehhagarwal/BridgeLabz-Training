using System;
using System.Collections.Generic;

public class RodCutter
{
    public int Maximize(Rod rod,PriceChart chart)
    {
        int n=rod.Length;
        int[] revenue=new int[n+1];

        int[] prices=chart.GetAll();

        for(int i = 1; i <= n; i++)
        {
            int maxRev=prices[i];

            for(int j = 1; j < i; j++)
            {
                int current=revenue[j]+revenue[i-j];
                if (current > maxRev)
                {
                    maxRev=current;
                }
            }

            revenue[i]=maxRev;
        }

        return revenue[n];
    }

    public int NonOptimize(Rod rod,PriceChart chart)
    {
        return chart.Get(rod.Length);
    }
}